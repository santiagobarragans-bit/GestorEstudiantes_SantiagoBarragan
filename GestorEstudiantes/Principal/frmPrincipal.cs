using DataSerializers.Serializers; 
using Modelos.Clases;              
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Principal
{
    public partial class frmPrincipal : Form
    {
        
        private List<Estudiante> estudiantes = new List<Estudiante>();
        private BindingList<Estudiante> bindingList;
        private string[,] memoria;
        private string archivoCsv;

        public frmPrincipal()
        {
            InitializeComponent();
            
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
  
            string carpetaArchivos = Path.Combine(Application.StartupPath, "Archivos");
            archivoCsv = Path.Combine(carpetaArchivos, "estudiantes.csv");

            // Si no existe, crear carpeta y archivo de ejemplo que es la que estoy utilizando
            if (!File.Exists(archivoCsv))
            {
                Directory.CreateDirectory(carpetaArchivos);
                var ejemplo = new List<Estudiante>
                {
                    new Estudiante { Nombre="Ana Gomez", Edad=19, Nota1=3.5, Nota2=4.0, Nota3=2.9, Genero="Femenino", Actividades = new List<string>{"Futbol","Musica"}, Email="ana@example.com" },
                    new Estudiante { Nombre="Juan Perez", Edad=21, Nota1=2.5, Nota2=3.0, Nota3=2.8, Genero="Masculino", Actividades = new List<string>{"Arte"}, Email="juan@miempresa.com" }
                };
                CsvSerializer.WriteCsv(archivoCsv, ejemplo);
            }

            // Leer estudiantes y bind al DataGridView para que los pueda mostrar
            estudiantes = CsvSerializer.ReadCsv(archivoCsv);
            bindingList = new BindingList<Estudiante>(estudiantes);
            bindingSourceEstudiantes.DataSource = bindingList;
            dgvEstudiantes.DataSource = bindingSourceEstudiantes;

            memoria = BuildMemoryArray(estudiantes);

            // Ajustes visuales por si acaso
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersVisible = false;
        }

        private string[,] BuildMemoryArray(List<Estudiante> list)
        {
            int cols = 10;
            int rows = list.Count;
            var arr = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                var e = list[i];
                arr[i, 0] = e.Nombre;
                arr[i, 1] = e.Edad.ToString();
                arr[i, 2] = e.Nota1.ToString(CultureInfo.InvariantCulture);
                arr[i, 3] = e.Nota2.ToString(CultureInfo.InvariantCulture);
                arr[i, 4] = e.Nota3.ToString(CultureInfo.InvariantCulture);
                arr[i, 5] = e.Genero;
                arr[i, 6] = e.Actividades != null ? string.Join(";", e.Actividades) : "";
                arr[i, 7] = e.Promedio.ToString(CultureInfo.InvariantCulture);
                arr[i, 8] = e.Estado;
                arr[i, 9] = e.Email ?? "";
            }
            return arr;
        }

        private void RefreshBindingsAndSave()
        {
            bindingList = new BindingList<Estudiante>(estudiantes);
            bindingSourceEstudiantes.DataSource = bindingList;
            dgvEstudiantes.Refresh();

            memoria = BuildMemoryArray(estudiantes);

            try
            {
                CsvSerializer.WriteCsv(archivoCsv, estudiantes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // validar registro de los estudiantes
        private bool ValidarRegistro(out string mensaje)
        {
            mensaje = "";
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) { mensaje = "Nombre requerido"; return false; }
            if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0) { mensaje = "Edad inválida"; return false; }
            if (!double.TryParse(txtNota1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double n1) || n1 < 0 || n1 > 5) { mensaje = "Nota1 inválida"; return false; }
            if (!double.TryParse(txtNota2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double n2) || n2 < 0 || n2 > 5) { mensaje = "Nota2 inválida"; return false; }
            if (!double.TryParse(txtNota3.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double n3) || n3 < 0 || n3 > 5) { mensaje = "Nota3 inválida"; return false; }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtEmail.Text, pattern))
                {
                    mensaje = "Email con formato inválido";
                    return false;
                }
            }

            return true;
        }

        // metodo para registrar 
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarRegistro(out string msg))
            {
                MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var actividades = new List<string>();
            if (cbDeportes.Checked) actividades.Add("Deportes");
            if (cbMusica.Checked) actividades.Add("Música");
            if (cbArte.Checked) actividades.Add("Arte");

            var genero = rbMasculino.Checked ? "Masculino" : (rbFemenino.Checked ? "Femenino" : "");

            var nuevo = new Estudiante
            {
                Nombre = txtNombre.Text.Trim(),
                Edad = int.Parse(txtEdad.Text),
                Nota1 = double.Parse(txtNota1.Text, CultureInfo.InvariantCulture),
                Nota2 = double.Parse(txtNota2.Text, CultureInfo.InvariantCulture),
                Nota3 = double.Parse(txtNota3.Text, CultureInfo.InvariantCulture),
                Genero = genero,
                Actividades = actividades,
                Email = txtEmail.Text.Trim()
            };

            estudiantes.Add(nuevo);
            RefreshBindingsAndSave();

            // Limpiar formulario
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            cbDeportes.Checked = cbMusica.Checked = cbArte.Checked = false;
            txtEmail.Text = "";

            MessageBox.Show("Estudiante registrado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // metodo para guardar datos de los estudiantes en el archivo CSV
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CsvSerializer.WriteCsv(archivoCsv, estudiantes);
                MessageBox.Show("CSV guardado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void dgvEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var item = dgvEstudiantes.Rows[e.RowIndex].DataBoundItem as Estudiante;
            if (item == null) return;

            var r = MessageBox.Show($"¿Eliminar a {item.Nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                estudiantes.Remove(item);
                RefreshBindingsAndSave();
            }
        }

        // metodo para buscar estudiantes por nombre y filtrarlos
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string q = txtBuscar.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(q))
            {
                bindingSourceEstudiantes.DataSource = new BindingList<Estudiante>(estudiantes);
            }
            else
            {
                var filtered = estudiantes.Where(x => x.Nombre != null && x.Nombre.ToLower().Contains(q)).ToList();
                bindingSourceEstudiantes.DataSource = new BindingList<Estudiante>(filtered);
            }
            dgvEstudiantes.Refresh();
        }

        private void dgvEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count == 0)
            {
                pbEstado.Image = null;
                if (txtDestinoEmail != null) txtDestinoEmail.Text = "";
                return;
            }

            var item = dgvEstudiantes.SelectedRows[0].DataBoundItem as Estudiante;
            if (item == null)
            {
                pbEstado.Image = null;
                if (txtDestinoEmail != null) txtDestinoEmail.Text = "";
                return;
            }

            // condisional simple para mostrar imagen de aprobado/reprobado del estudiante
            try
            {
                if (item.Estado == "Aprobado")
                    pbEstado.Image = Properties.Resources.aprobado;
                else
                    pbEstado.Image = Properties.Resources.reprobado;
            }
            catch
            {
                pbEstado.Image = null;
            }

            // auto-fill email destino con el email del estudiante seleccionado
            if (txtDestinoEmail != null) txtDestinoEmail.Text = item.Email ?? "";
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Title = "Seleccionar archivos para adjuntar";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in ofd.FileNames)
                    {
                        if (!lstAdjuntos.Items.Contains(f))
                            lstAdjuntos.Items.Add(f);
                    }
                }
            }
        }

        private bool ValidarEmailYDominio(string email, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(email)) { error = "Email vacío"; return false; }
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern)) { error = "Formato email inválido"; return false; }

            var allowed = ConfigurationManager.AppSettings["AllowedDomains"] ?? "";
            if (string.IsNullOrWhiteSpace(allowed)) return true; // sin whitelist -> permitir
            var domain = email.Split('@').Last().ToLowerInvariant();
            var list = allowed.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim().ToLowerInvariant());
            if (!list.Contains(domain)) { error = $"Dominio '{domain}' no está en la whitelist."; return false; }
            return true;
        }

        // metodo para enviar correo 
        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            string destino = txtDestinoEmail.Text.Trim();
            if (!ValidarEmailYDominio(destino, out string err))
            {
                MessageBox.Show(err, "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string asunto = txtAsunto.Text.Trim();
            string cuerpo = txtCuerpo.Text ?? "";

            try
            {
                string host = ConfigurationManager.AppSettings["SmtpHost"] ?? "localhost";
                int port = int.TryParse(ConfigurationManager.AppSettings["SmtpPort"], out int p) ? p : 25;
                bool enableSsl = bool.TryParse(ConfigurationManager.AppSettings["SmtpEnableSsl"], out bool s) ? s : false;
                string from = ConfigurationManager.AppSettings["FromEmail"] ?? "no-reply@miapp.local";

                using (var msg = new MailMessage())
                {
                    msg.From = new MailAddress(from);
                    msg.To.Add(destino);
                    msg.Subject = asunto;
                    msg.Body = cuerpo;
                    msg.IsBodyHtml = false;

                    foreach (var item in lstAdjuntos.Items)
                    {
                        var path = item as string;
                        if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
                        {
                            msg.Attachments.Add(new Attachment(path));
                        }
                    }

                    using (var smtp = new SmtpClient(host, port))
                    {
                        smtp.EnableSsl = enableSsl;
                        smtp.Send(msg);
                    }
                }

                MessageBox.Show("Correo enviado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enviando correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
