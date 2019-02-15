using System;
namespace Herencia
{
    public class Circulo : FiguraGeometrica
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