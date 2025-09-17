using System;
using System.Collections.Generic;

namespace Modelos.Clases
{
    /// Representa un estudiante con notas, actividades y estado académico.
    
    public class Estudiante // <-- Debe ser PUBLIC para que otros proyectos lo vean
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public string Genero { get; set; } // Masculino / Femenino
        public List<string> Actividades { get; set; } = new List<string>();
        public string Email { get; set; }

        // Calcula el promedio automáticamente
        public double Promedio
        {
            get
            {
                return Math.Round((Nota1 + Nota2 + Nota3) / 3.0, 2);
            }
        }

        // Determina el estado (Aprobado/Reprobado)
        public string Estado
        {
            get
            {
                return Promedio >= 3.0 ? "Aprobado" : "Reprobado";
            }
        }
    }
}