using System;

namespace AgenciaViajes
{
    // herencia
    public class ViajeInternacional : Viaje
    {
        //PROPIEDADES NUEVAS 
        public bool RequiereVisa { get; set; }   // true o false (sí o no)
        public string Aerolinea { get; set; }    // Nombre de la aerolínea

        //CONSTRUCTOR de ViajeInternacional con mas parametros que la clase padre
        
        public ViajeInternacional(int id, string destino, int duracion, decimal precio,
                                bool requiereVisa, string aerolinea)
            : base(id, destino, duracion, precio, "Internacional") // Llama al constructor padre
        {
            
            this.RequiereVisa = requiereVisa;
            this.Aerolinea = aerolinea;

           
        }
    }
}