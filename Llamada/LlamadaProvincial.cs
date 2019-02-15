namespace Llamada
{
    public class LlamadaProvincial : Llamadas
    {
        private double precio1;
        private double precio2;
        private double precio3;
        private int franja;
        public double Precio1
        {
            get{return precio1;}
            set{precio1 = value;}
        }
        public double Precio2
        {
            get{return precio2;}
            set{precio2 = value;}
        }
           public double Precio3
        {
            get{return precio3;}
            set{precio3 = value;}
        }
           public int Franja
        {
            get{return franja;}
            set{franja = value;}
        }
        public override double CalcularPrecio()
        {
            double resultado = 0;
            if(this.Franja == 0 ){
                resultado = this.Precio1 * this.Duracion;
            }
            else if (this.Franja == 1)
            {
                 resultado = this.precio3 * this.Duracion;
            }
            return resultado;
        }
    }
}