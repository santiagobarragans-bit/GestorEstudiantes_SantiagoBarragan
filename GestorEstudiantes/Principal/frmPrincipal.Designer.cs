namespace Principal
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox gbRegistro1;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox cbMusica;
        private System.Windows.Forms.CheckBox cbDeportes;
        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox cbArte;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox pbEstado;
        private System.Windows.Forms.BindingSource bindingSourceEstudiantes;

        // Controles para correo
        private System.Windows.Forms.GroupBox gbCorreo1;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblCuerpo;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtDestinoEmail;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.ListBox lstAdjuntos;

        /// <summary>
        /// Limpia los recursos usados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbRegistro1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbArte = new System.Windows.Forms.CheckBox();
            this.cbMusica = new System.Windows.Forms.CheckBox();
            this.cbDeportes = new System.Windows.Forms.CheckBox();
            this.lblAct = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.pbEstado = new System.Windows.Forms.PictureBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.bindingSourceEstudiantes = new System.Windows.Forms.BindingSource(this.components);
            this.gbCorreo1 = new System.Windows.Forms.GroupBox();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.lstAdjuntos = new System.Windows.Forms.ListBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.lblCuerpo = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtDestinoEmail = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();

            // BeginInit
            ((System.ComponentModel.ISupportInitialize)(this.pbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEstudiantes)).BeginInit();
            this.SuspendLayout();

            // 
            // gbRegistro1
            // 
            this.gbRegistro1.BackColor = System.Drawing.Color.AliceBlue;
            this.gbRegistro1.Controls.Add(this.btnGuardar);
            this.gbRegistro1.Controls.Add(this.btnRegistrar);
            this.gbRegistro1.Controls.Add(this.txtEmail);
            this.gbRegistro1.Controls.Add(this.lblEmail);
            this.gbRegistro1.Controls.Add(this.cbArte);
            this.gbRegistro1.Controls.Add(this.cbMusica);
            this.gbRegistro1.Controls.Add(this.cbDeportes);
            this.gbRegistro1.Controls.Add(this.lblAct);
            this.gbRegistro1.Controls.Add(this.rbFemenino);
            this.gbRegistro1.Controls.Add(this.rbMasculino);
            this.gbRegistro1.Controls.Add(this.lblGenero);
            this.gbRegistro1.Controls.Add(this.txtNota3);
            this.gbRegistro1.Controls.Add(this.lblNota3);
            this.gbRegistro1.Controls.Add(this.txtNota2);
            this.gbRegistro1.Controls.Add(this.lblNota2);
            this.gbRegistro1.Controls.Add(this.txtNota1);
            this.gbRegistro1.Controls.Add(this.lblNota1);
            this.gbRegistro1.Controls.Add(this.txtEdad);
            this.gbRegistro1.Controls.Add(this.lblEdad);
            this.gbRegistro1.Controls.Add(this.txtNombre);
            this.gbRegistro1.Controls.Add(this.lblNombre);
            this.gbRegistro1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbRegistro1.Location = new System.Drawing.Point(20, 20);
            this.gbRegistro1.Name = "gbRegistro1";
            this.gbRegistro1.Size = new System.Drawing.Size(326, 420);
            this.gbRegistro1.TabIndex = 1;
            this.gbRegistro1.TabStop = false;
            this.gbRegistro1.Text = "Registro de Estudiante";

            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuardar.Location = new System.Drawing.Point(140, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 34);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar CSV";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegistrar.Location = new System.Drawing.Point(20, 350);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 34);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 307);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 25);
            this.txtEmail.TabIndex = 18;

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 310);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";

            // 
            // cbArte
            // 
            this.cbArte.AutoSize = true;
            this.cbArte.Location = new System.Drawing.Point(200, 275);
            this.cbArte.Name = "cbArte";
            this.cbArte.Size = new System.Drawing.Size(53, 21);
            this.cbArte.TabIndex = 16;
            this.cbArte.Text = "Arte";
            this.cbArte.UseVisualStyleBackColor = true;

            // 
            // cbMusica
            // 
            this.cbMusica.AutoSize = true;
            this.cbMusica.Location = new System.Drawing.Point(120, 275);
            this.cbMusica.Name = "cbMusica";
            this.cbMusica.Size = new System.Drawing.Size(70, 21);
            this.cbMusica.TabIndex = 15;
            this.cbMusica.Text = "Musica";
            this.cbMusica.UseVisualStyleBackColor = true;

            // 
            // cbDeportes
            // 
            this.cbDeportes.AutoSize = true;
            this.cbDeportes.Location = new System.Drawing.Point(120, 248);
            this.cbDeportes.Name = "cbDeportes";
            this.cbDeportes.Size = new System.Drawing.Size(83, 21);
            this.cbDeportes.TabIndex = 14;
            this.cbDeportes.Text = "Deportes";
            this.cbDeportes.UseVisualStyleBackColor = true;

            // 
            // lblAct
            // 
            this.lblAct.AutoSize = true;
            this.lblAct.Location = new System.Drawing.Point(20, 250);
            this.lblAct.Name = "lblAct";
            this.lblAct.Size = new System.Drawing.Size(79, 17);
            this.lblAct.TabIndex = 13;
            this.lblAct.Text = "Actividades";

            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(210, 211);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(87, 21);
            this.rbFemenino.TabIndex = 12;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;

            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(120, 211);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(89, 21);
            this.rbMasculino.TabIndex = 11;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;

            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(20, 213);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(56, 17);
            this.lblGenero.TabIndex = 10;
            this.lblGenero.Text = "Género:";

            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(120, 176);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 25);
            this.txtNota3.TabIndex = 9;

            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(20, 176);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(53, 17);
            this.lblNota3.TabIndex = 8;
            this.lblNota3.Text = "Nota 3:";

            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(120, 139);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 25);
            this.txtNota2.TabIndex = 7;

            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(20, 139);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(53, 17);
            this.lblNota2.TabIndex = 6;
            this.lblNota2.Text = "Nota 2:";

            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(120, 99);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 25);
            this.txtNota1.TabIndex = 5;

            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(20, 102);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(53, 17);
            this.lblNota1.TabIndex = 4;
            this.lblNota1.Text = "Nota 1:";

            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(120, 65);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 25);
            this.txtEdad.TabIndex = 3;

            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(20, 65);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(42, 17);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";

            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 25);
            this.txtNombre.TabIndex = 1;

            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";

            // 
            // gbListado
            // 
            this.gbListado.BackColor = System.Drawing.Color.Honeydew;
            this.gbListado.Controls.Add(this.pbEstado);
            this.gbListado.Controls.Add(this.dgvEstudiantes);
            this.gbListado.Controls.Add(this.txtBuscar);
            this.gbListado.Controls.Add(this.lblBuscar);
            this.gbListado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbListado.Location = new System.Drawing.Point(352, 20);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(540, 550);
            this.gbListado.TabIndex = 2;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado de Estudiantes";

            // 
            // pbEstado
            // 
            this.pbEstado.Location = new System.Drawing.Point(430, 20);
            this.pbEstado.Name = "pbEstado";
            this.pbEstado.Size = new System.Drawing.Size(50, 40);
            this.pbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstado.TabIndex = 3;
            this.pbEstado.TabStop = false;

            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(20, 70);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(500, 420);
            this.dgvEstudiantes.TabIndex = 2;
            this.dgvEstudiantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellDoubleClick);
            this.dgvEstudiantes.SelectionChanged += new System.EventHandler(this.dgvEstudiantes_SelectionChanged);

            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(80, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(240, 23);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(20, 28);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(47, 15);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";

            // 
            // gbCorreo1
            // 
            this.gbCorreo1.Controls.Add(this.btnEnviarCorreo);
            this.gbCorreo1.Controls.Add(this.lstAdjuntos);
            this.gbCorreo1.Controls.Add(this.btnAdjuntar);
            this.gbCorreo1.Controls.Add(this.txtCuerpo);
            this.gbCorreo1.Controls.Add(this.lblCuerpo);
            this.gbCorreo1.Controls.Add(this.txtAsunto);
            this.gbCorreo1.Controls.Add(this.lblAsunto);
            this.gbCorreo1.Controls.Add(this.txtDestinoEmail);
            this.gbCorreo1.Controls.Add(this.lblDestino);
            this.gbCorreo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbCorreo1.Location = new System.Drawing.Point(900, 20);
            this.gbCorreo1.Name = "gbCorreo1";
            this.gbCorreo1.Size = new System.Drawing.Size(458, 296);
            this.gbCorreo1.TabIndex = 3;
            this.gbCorreo1.TabStop = false;
            this.gbCorreo1.Text = "Envío de correo";

            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.BackColor = System.Drawing.Color.LightGreen;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(220, 238);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(75, 40);
            this.btnEnviarCorreo.TabIndex = 8;
            this.btnEnviarCorreo.Text = "Enviar Correo";
            this.btnEnviarCorreo.UseVisualStyleBackColor = false;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);

            // 
            // lstAdjuntos
            // 
            this.lstAdjuntos.FormattingEnabled = true;
            this.lstAdjuntos.ItemHeight = 15;
            this.lstAdjuntos.Location = new System.Drawing.Point(94, 176);
            this.lstAdjuntos.Name = "lstAdjuntos";
            this.lstAdjuntos.Size = new System.Drawing.Size(358, 49);
            this.lstAdjuntos.TabIndex = 7;

            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(13, 178);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(75, 37);
            this.btnAdjuntar.TabIndex = 6;
            this.btnAdjuntar.Text = "Adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);

            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Location = new System.Drawing.Point(66, 96);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(386, 60);
            this.txtCuerpo.TabIndex = 5;

            // 
            // lblCuerpo
            // 
            this.lblCuerpo.AutoSize = true;
            this.lblCuerpo.Location = new System.Drawing.Point(10, 99);
            this.lblCuerpo.Name = "lblCuerpo";
            this.lblCuerpo.Size = new System.Drawing.Size(50, 15);
            this.lblCuerpo.TabIndex = 4;
            this.lblCuerpo.Text = "Cuerpo:";

            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(65, 54);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(387, 23);
            this.txtAsunto.TabIndex = 3;

            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(10, 54);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(49, 15);
            this.lblAsunto.TabIndex = 2;
            this.lblAsunto.Text = "Asunto:";

            // 
            // txtDestinoEmail
            // 
            this.txtDestinoEmail.Location = new System.Drawing.Point(65, 20);
            this.txtDestinoEmail.Name = "txtDestinoEmail";
            this.txtDestinoEmail.Size = new System.Drawing.Size(230, 23);
            this.txtDestinoEmail.TabIndex = 1;

            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 25);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(53, 15);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Destino:";

            // 
            // frmPrincipal (form)
            // 
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.gbCorreo1);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbRegistro1);
            this.Name = "frmPrincipal";
            this.Text = "Gestor de Estudiantes";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);

            // EndInit and Resume
            ((System.ComponentModel.ISupportInitialize)(this.pbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEstudiantes)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

