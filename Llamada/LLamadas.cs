using System;
namespace Llamada
{
    public abstract class Llamadas
    {
        private string numOrigen;
        private string numDestino;
        private double duracion;
        public string NumOrigen
        {
            get{return numOrigen;}
            set{numOrigen=value;}
        }
        public string NumDestino
        {
            get{return numDestino;}
            set{numDestino=value;}
        }
        public double Duracion
        {
            get{return duracion;}
            set{duracion=value;}
        }
        public abstract double CalcularPrecio();
        public override string ToString()
        {
            return $"#origen: {this.numOrigen}- #destino: {this.numDestino}- #duracion: {this.duracion}";
        }
    }
}