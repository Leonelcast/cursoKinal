namespace Llamada
{
    public class LlamadaLocal : Llamadas
    {
        private double precio;
        public double Precio
        {
            get{return precio;}
            set{precio = value;}
        }
        public override double CalcularPrecio()
        {
            return this.Precio * this.Duracion;    
        }
    }
}