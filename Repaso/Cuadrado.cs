namespace Repaso
{
    //heredadando las propiedades de la clase padre
    public class Cuadrado : FigurasGeometricas
    {
        private int radio;
        public int Radio
        {
            get{return radio;}
            set{radio = value;}
        }
        public override int CalcularArea()
        {
            return (PosicionX*PosicionX);
        }
    }
}