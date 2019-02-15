using System;
namespace Publication
{
    public class Revista : Publicaciones
    {
        private int id;
        public int Id
        {
            get{return id;}
            set{id=value;}
        }
    }
    
}