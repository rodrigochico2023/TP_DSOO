using System;
using System.Collections.Generic;

namespace ClubDeportivo
{
    internal class Socio
    {
        // Atributos
        
        public int IdSocio { get; set; }  
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public List<Actividad> Inscripciones { get; set; }  // Lista de actividades en las que el socio está inscrito

        // Constructor
        
        public Socio(int idSocio, string nombre, string apellido)
        {
            // Asignamos los valores recibidos como parámetros a las propiedades del socio.
            IdSocio = idSocio;
            Nombre = nombre;
            Apellido = apellido;

            // Inicializamos la lista de inscripciones vacía.
            
            Inscripciones = new List<Actividad>();
        }
    }
}


