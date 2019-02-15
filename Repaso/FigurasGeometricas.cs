namespace Repaso
{
     public abstract class FigurasGeometricas
    { //propiedades que las clases hijas heredan de la padre
        private int posicionX;
        private int posicionY;
        private string color;
        private string forma;

        //encapsulamiento
        public int PosicionX
        {
            get{return posicionX;}
            set{posicionX = value;}
        }
          public int PosicionY
        {
            get{return posicionY;}
            set{posicionY = value;}
        }
          public string Color
        {
            get{return color;}
            set{color = value;}
        }
         public string Forma
        {
            get{return color;}
            set{color = value;}
        }
        public abstract int CalcularArea();
    }
   
    
}