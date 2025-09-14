using System;
using System.Collections.Generic;
using System.Linq;

namespace AgenciaViajes
{
    public class GestorViajes
    {
        // LISTA donde guardaremos TODOS los viajes 
        private List<Viaje> viajes = new List<Viaje>();

        // CONTADOR para IDs automaticos
        private int nextId = 1;

        //FUNCION 1: AGREGAR VIAJE NACIONAL
        public void AgregarViajeNacional(string destino, int duracion, decimal precio)
        {
            // Crear el viaje nacional
            Viaje nuevoViaje = new Viaje(nextId, destino, duracion, precio, "Nacional");

            
            viajes.Add(nuevoViaje);

            // Aumentar el contador para el próximo ID
            nextId++;

            Console.WriteLine($"✅ Viaje nacional agregado: {destino}");
        }

        // FUNCION 2: AGREGAR VIAJE INTERNACIONAL  
        public void AgregarViajeInternacional(string destino, int duracion, decimal precio,
                                            bool requiereVisa, string aerolinea)
        {
            // Crear el viaje internacional 
            ViajeInternacional nuevoViaje = new ViajeInternacional(nextId, destino, duracion,
                                                                precio, requiereVisa, aerolinea);

            viajes.Add(nuevoViaje);
            nextId++;

            Console.WriteLine($"✅ Viaje internacional agregado: {destino}");
        }

        //FUNCION 3:OBTENER TODOS LOS VIAJES (para mostrar en GridView)
        public List<Viaje> ObtenerTodosLosViajes()
        {
            // Devuelve la lista completa (toda la caja de zapatos)
            return viajes;
        }

        //FUNCION 4:BUSCAR VIAJES POR DESTINO
        public List<Viaje> BuscarPorDestino(string textoBusqueda)
        {
            // FindAll busca todos los viajes que contengan el texto en el destino
            // Like buscar "can" encuentra "Cancún", "Canada"
            return viajes.FindAll(v => v.Destino.Contains(textoBusqueda));
        }

        // FUNCION 5: ELIMINAR VIAJE POR ID
        public bool EliminarViaje(int id)
        {
            // Buscar el viaje por su ID
            Viaje viajeAEliminar = viajes.Find(v => v.Id == id);

            if (viajeAEliminar != null)
            {
                // Si lo encontro, lo elimina
                viajes.Remove(viajeAEliminar);
                Console.WriteLine($"❌ Viaje eliminado: ID {id}");
                return true; // Exito
            }

            Console.WriteLine($"⚠️ No se encontró viaje con ID {id}");
            return false; // Fallo
        }

        // FUNCION 6:OBTENER ESTADISTICAS
        public string ObtenerEstadisticas()
        {
            if (viajes.Count == 0)
                return "📊 No hay viajes registrados";

            // Cálculos simples
            decimal promedioPrecio = viajes.Average(v => v.Precio);
            int totalInternacionales = viajes.Count(v => v.Tipo == "Internacional");
            int totalNacionales = viajes.Count(v => v.Tipo == "Nacional");
            Viaje viajeMasCaro = viajes.OrderByDescending(v => v.Precio).First();

            return $"📊 ESTADÍSTICAS:\n" +
                   $"• Total viajes: {viajes.Count}\n" +
                   $"• Promedio de precio: ${promedioPrecio:F2}\n" +
                   $"• Viajes internacionales: {totalInternacionales}\n" +
                   $"• Viajes nacionales: {totalNacionales}\n" +
                   $"• Viaje más caro: {viajeMasCaro.Destino} (${viajeMasCaro.Precio})";
        }

        
        public Viaje ObtenerViajePorId(int id)
        {
            return viajes.Find(v => v.Id == id);
        }
    }
}