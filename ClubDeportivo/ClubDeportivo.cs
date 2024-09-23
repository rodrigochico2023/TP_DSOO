using System;
using System.Collections.Generic;

namespace ClubDeportivo
{
    internal class ClubDeportivo
    {
        // Atributos
        public List<Socio> Socios { get; set; }  // Almacena una lista de objetos de tipo 'Socio'
        public List<Actividad> Actividades { get; set; }  // Almacena una lista de objetos de tipo 'Actividad'

        // Constructor
       public ClubDeportivo()
        {
            // Inicializamos las listas vacías cuando se crea un nuevo club.
            Socios = new List<Socio>();
            Actividades = new List<Actividad>();
        }

        // Método para dar de alta a un socio
        
        public void AltaSocio(int idSocio, string nombre, string apellido)
        {
            // Creamos un nuevo objeto de tipo 'Socio' y lo añadimos a la lista de socios.
            Socios.Add(new Socio(idSocio, nombre, apellido));
        }

        // Método para agregar una nueva actividad
        public void AgregarActividad(string nombreActividad, int cupos)
        {
            // Se genera un nuevo ID basado en el número de actividades existentes.
            int nuevoId = Actividades.Count + 1;
            // Creamos un nuevo objeto de tipo 'Actividad' y lo añadimos a la lista de actividades.
            Actividades.Add(new Actividad(nuevoId, nombreActividad, cupos));
        }

        // Método para inscribir a un socio en una actividad
        public void InscribirActividad(string nombreActividad, int idSocio)
        {
            // Buscamos al socio en la lista de socios usando el ID
            Socio socio = Socios.Find(s => s.IdSocio == idSocio);
            // Buscamos la actividad en la lista de actividades por el nombre
            Actividad actividad = Actividades.Find(a => a.Nombre == nombreActividad);

            // Verificamos que el socio y la actividad existan, y que haya cupos disponibles en la actividad.
            if (socio != null && actividad != null && actividad.ReservarCupo())
            {
                // Añadimoa a la lista de inscripciones del socio
                socio.Inscripciones.Add(actividad);
                
                Console.WriteLine($"El socio {socio.Nombre} se inscribió en {actividad.Nombre}.");
            }
            else
            {
                // Cupos agotados o socio no encontrado
                Console.WriteLine($"No se pudo inscribir al socio en la actividad {nombreActividad}.");
            }
        }
    }
}
