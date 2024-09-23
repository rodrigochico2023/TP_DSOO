using System;

namespace ClubDeportivo
{
    internal class Program
    {
        // Método principal
        static void Main(string[] args)
        {
            // Creamos una instancia del club deportivo
            ClubDeportivo club = new ClubDeportivo();
            bool salir = false; 

            // Bucle que mantiene el programa en funcionamiento hasta que el usuario decida salir
            while (!salir)
            {
                Console.Clear(); 
                Console.WriteLine("=== Sistema del Club Deportivo ===");
                Console.WriteLine("1. Alta de socio");
                Console.WriteLine("2. Agregar actividad");
                Console.WriteLine("3. Inscribir socio en actividad");
                Console.WriteLine("4. Ver inscripciones de un socio");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine(); 

                // Control de flujo, según la opción seleccionada
                switch (opcion)
                {
                    case "1":
                        AltaSocio(club); // LLamamos al método para dar de alta un socio
                        break;
                    case "2":
                        AgregarActividad(club); // Llamamos al método para agregar una actividad
                        break;
                    case "3":
                        InscribirSocioEnActividad(club); // Llamamos al método para inscribir a un socio en una actividad
                        break;
                    case "4":
                        VerInscripcionesSocio(club); // Llamamos al método para ver inscripciones de un socio
                        break;
                    case "5":
                        salir = true; 
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente."); 
                        break;
                }

                
                if (!salir)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        // Método para dar de alta un socio
        static void AltaSocio(ClubDeportivo club)
        {
            Console.Clear();
            Console.WriteLine("=== Alta de socio ===");
            Console.Write("Ingrese el ID del socio: ");
            int idSocio = int.Parse(Console.ReadLine()); 
            Console.Write("Ingrese el nombre del socio: ");
            string nombre = Console.ReadLine(); 
            Console.Write("Ingrese el apellido del socio: ");
            string apellido = Console.ReadLine(); 

            // Llamamos al método para agregar el socio al club
            club.AltaSocio(idSocio, nombre, apellido);
            Console.WriteLine($"El socio {nombre} {apellido} ha sido dado de alta con éxito.");
        }

        // Método para agregar una nueva actividad al club
        static void AgregarActividad(ClubDeportivo club)
        {
            Console.Clear();
            Console.WriteLine("=== Agregar actividad ===");
            Console.Write("Ingrese el nombre de la actividad: ");
            string nombreActividad = Console.ReadLine(); 
            Console.Write("Ingrese los cupos disponibles: ");
            int cupos = int.Parse(Console.ReadLine()); 

            // Llamamos al método para agregar la actividad al club
            club.AgregarActividad(nombreActividad, cupos);
            Console.WriteLine($"La actividad {nombreActividad} se ha agregado con {cupos} cupos.");
        }

        // Método para inscribir a un socio en una actividad
        static void InscribirSocioEnActividad(ClubDeportivo club)
        {
            Console.Clear();
            Console.WriteLine("=== Inscribir socio en actividad ===");
            Console.Write("Ingrese el ID del socio: ");
            int idSocio = int.Parse(Console.ReadLine()); 
            Console.Write("Ingrese el nombre de la actividad: ");
            string nombreActividad = Console.ReadLine(); 

            // Llamamos al método para inscribir al socio en la actividad
            club.InscribirActividad(nombreActividad, idSocio);
        }

        // Método para ver las inscripciones de un socio
        static void VerInscripcionesSocio(ClubDeportivo club)
        {
            Console.Clear();
            Console.WriteLine("=== Ver inscripciones de un socio ===");
            Console.Write("Ingrese el ID del socio: ");
            int idSocio = int.Parse(Console.ReadLine()); 

            // Buscamos y mostramos el socio por ID en la lista de socios
            Socio socio = club.Socios.Find(s => s.IdSocio == idSocio);

            
            if (socio != null)
            {
                Console.WriteLine($"Inscripciones del socio {socio.Nombre} {socio.Apellido}:");
                foreach (var actividad in socio.Inscripciones)
                {
                    Console.WriteLine($"- {actividad.Nombre}"); // Muestramos el nombre de cada actividad en la que está inscrito
                }
            }
            else
            {
                Console.WriteLine("Socio no encontrado."); 
            }
        }
    }
}
