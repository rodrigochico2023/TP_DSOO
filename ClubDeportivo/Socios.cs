using System;
using System.Collections.Generic;

namespace ClubDeportivo
{
    internal class Socio
    {
        // Atributos
        public int IdSocio { get; private set; }  // El ID ahora es generado automáticamente
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Actividad> Inscripciones { get; set; }  // Lista de actividades en las que el socio está inscrito

        // Contador estático para generar IDs automáticamente
        private static int contador = 1;

        // Constructor
        public Socio(string nombre, string apellido)
        {
            // Asignamos un ID automáticamente e incrementamos el contador
            IdSocio = contador++;

            // Asignamos los valores recibidos como parámetros a las propiedades del socio.
            Nombre = nombre;
            Apellido = apellido;

            // Inicializamos la lista de inscripciones vacía.
            Inscripciones = new List<Actividad>();
        }

        // Sobrescribimos el método ToString para facilitar la visualización
        public override string ToString()
        {
            return $"ID: {IdSocio}, Nombre: {Nombre} {Apellido}";
        }
    }
}
