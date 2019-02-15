namespace Herencia
{

    public abstract class FiguraGeometrica
     {
        //Propiedades, siempre privadas
        // las clases abstractas NO se pueden instanciar 
        //abstraccion es cuando se comparten las propiedades

        private int posicionX;
        private int posicionY;
        private string color;
        private string forma;

        public int PosicionX
        { 
            get{return posicionX;}
            set{posicionX=value;}
        }
        public int PosicionY
        { 
            get{return posicionY;}
            set{posicionY=value;}
        }
         public string Color
        { 
            get{return color;}
            set{color=value;}
        }
         public string Forma
        { 
            get{return forma;}
            set{forma=value;}
        }
        public abstract int CalcularArea();
       
     }

}
    
