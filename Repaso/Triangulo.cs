namespace Repaso
{
    //heredadando las propiedades de la clase padre
    public class Triangulo : FigurasGeometricas
    {
        private int radio;
        public int Radio
        {
            get{return radio;}
            set{radio = value;}
        }
        public override int CalcularArea()
        {
            return (PosicionX*PosicionY)/2;
        }
        
    }
}