namespace Herencia
{
    //con esto se aplica la herencia : 
    public class Cuadrado : FiguraGeometrica
    {
        public override int CalcularArea()
        {
            return PosicionX * PosicionX;
        }
        
    }
}