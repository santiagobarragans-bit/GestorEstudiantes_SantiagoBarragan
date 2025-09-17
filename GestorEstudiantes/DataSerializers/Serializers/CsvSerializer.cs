using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Modelos.Clases;

namespace DataSerializers.Serializers
{
    public static class CsvSerializer
    {

        private const string Header = "Nombre,Edad,Nota1,Nota2,Nota3,Genero,Actividades,Promedio,Estado,Email";


        public static void WriteCsv(string path, IEnumerable<Estudiante> estudiantes, Encoding encoding = null)
        {

            if (encoding == null) encoding = Encoding.UTF8;

            // Asegurarnos de que la carpeta exista
            var dir = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using (var sw = new StreamWriter(path, false, encoding))
            {

                sw.WriteLine(Header);

                // Recorremos el arreglo cada estudiante y escribimos una línea por persona
                foreach (var e in estudiantes)
                {
                    string actividades = e.Actividades != null ? string.Join(";", e.Actividades) : "";

                    var campos = new string[]
                    {
                        Escape(e.Nombre),
                        e.Edad.ToString(),
                        e.Nota1.ToString(System.Globalization.CultureInfo.InvariantCulture),
                        e.Nota2.ToString(System.Globalization.CultureInfo.InvariantCulture),
                        e.Nota3.ToString(System.Globalization.CultureInfo.InvariantCulture),
                        Escape(e.Genero),
                        Escape(actividades),
                        e.Promedio.ToString(System.Globalization.CultureInfo.InvariantCulture),
                        Escape(e.Estado),
                        Escape(e.Email ?? "")
                    };

                    sw.WriteLine(string.Join(",", campos));
                }
            }
        }

        /// Método para leer un archivo CSV y reconstruye una lista de Estudiante.
 
        public static List<Estudiante> ReadCsv(string path, Encoding encoding = null)
        {
            var list = new List<Estudiante>();
            if (encoding == null) encoding = Encoding.UTF8;

            // Si no existe el archivo devolvemos lista vacía
            if (!File.Exists(path)) return list;

            using (var sr = new StreamReader(path, encoding))
            {
                // Leemos la primera línea (header) y la descartamos
                string headerLine = sr.ReadLine();
                if (headerLine == null) return list;

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue; // saltar líneas en blanco

                    // Parsear la línea respetando comillas y comas dentro de campos
                    string[] cols = ParseCsvLine(line);
                    if (cols.Length < 10) continue; // fila malformada -> ignorar

                    // Reconstruir el objeto Estudiante con parseos seguros
                    var est = new Estudiante
                    {
                        Nombre = cols[0],
                        Edad = int.TryParse(cols[1], out int edad) ? edad : 0,
                        Nota1 = double.TryParse(cols[2], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double n1) ? n1 : 0,
                        Nota2 = double.TryParse(cols[3], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double n2) ? n2 : 0,
                        Nota3 = double.TryParse(cols[4], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double n3) ? n3 : 0,
                        Genero = cols[5],
                        // Actividades se parsean separando por ';'
                        Actividades = ParseActividades(cols[6]),
                        Email = cols[9]
                        // Promedio y Estado no se usan para reconstruir (pueden recalcularse en la clase)
                    };

                    list.Add(est);
                }
            }

            return list;
        }

        #region Helpers

 

        private static string Escape(string s)
        {
            if (s == null) return "";
            if (s.Contains("\"")) s = s.Replace("\"", "\"\"");
            if (s.Contains(",") || s.Contains("\"") || s.Contains("\n") || s.Contains("\r"))
                return $"\"{s}\"";
            return s;
        }

        /// Parser manual de una línea CSV que respeta comillas.
        /// Soporta campos entrecomillados y comillas escapadas como "".


        private static string[] ParseCsvLine(string line)
        {
            var result = new List<string>();
            if (line == null) return result.ToArray();

            var cur = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {

                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        cur.Append('"'); 
                        i++; 
                    }
                    else
                    {
                        // abrir o cerrar comillas
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {

                    result.Add(cur.ToString());
                    cur.Clear();
                }
                else
                {
                    // Carácter normal dentro o fuera de comillas
                    cur.Append(c);
                }
            }

            result.Add(cur.ToString());
            return result.ToArray();
        }


        /// Convierte el campo "Actividades" (separadas por ';') en una lista de strings.

        private static List<string> ParseActividades(string field)
        {
            var list = new List<string>();
            if (string.IsNullOrWhiteSpace(field)) return list;

            var parts = field.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var p in parts) list.Add(p.Trim());

            return list;
        }

        #endregion
    }
}
