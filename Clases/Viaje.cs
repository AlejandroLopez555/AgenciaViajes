using System;

namespace AgenciaViajes
{
    //Clase padre (viaje)
    public class Viaje
    {
        
        public int Id { get; set; }          
        public string Destino { get; set; }  
        public int Duracion { get; set; }    
        public decimal Precio { get; set; }  
        public string Tipo { get; set; }     

        //constructor
        
        public Viaje(int id, string destino, int duracion, decimal precio, string tipo)
        {
           
            this.Id = id;            
            this.Destino = destino;  
            this.Duracion = duracion;
            this.Precio = precio;
            this.Tipo = tipo;
        }
    }
}