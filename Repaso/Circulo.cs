using System;
namespace Repaso
{
    //heredadando las propiedades de la clase padre
    public class Circulo : FigurasGeometricas
    {
         private int radio;
        public int Radio
        {
            get{ return radio;}
            set{radio=value;}

        }
        public override int CalcularArea()
        {
            return Convert.ToInt32(Math.PI*Math.Pow(Radio,2));
        }
    }
}