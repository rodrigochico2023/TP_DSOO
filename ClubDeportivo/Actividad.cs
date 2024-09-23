using System;

namespace ClubDeportivo
{
    internal class Actividad
    {
        // Atributos
        
        public int IdActividad { get; set; }  
        public string Nombre { get; set; }  
        public int CuposDisponibles { get; set; }  

        // Constructor
        
        public Actividad(int idActividad, string nombre, int cuposDisponibles)
        {
            // Asignamos los valores recibidos como parámetros a las propiedades de la actividad.
            IdActividad = idActividad;
            Nombre = nombre;
            CuposDisponibles = cuposDisponibles;
        }

        // Método para reservar un cupo
        
        public bool ReservarCupo()
        {
            // Verificamos si aún quedan cupos disponibles.
            if (CuposDisponibles > 0)
            {
                // Si hay cupos, se reduce el número de cupos disponibles y retorna true.
                CuposDisponibles--;
                return true;
            }
            // Si no hay cupos disponibles, retorna false.
            return false;
        }
    }
}


