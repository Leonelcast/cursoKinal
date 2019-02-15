using System;
namespace Publication
{
    public abstract class Publicaciones
    {
        private string titulo;
        private string editorial;
        private string autores;
        private DateTime dia;

        public string Titulo
        {
            get{return titulo;}
            set{titulo=value;}
        }
        public string Editorial
        {
            get{return editorial;}
            set{editorial=value;}
        }
        public string Autores
        {
            get{return autores;}
            set{autores=value;}
        }
        public DateTime Dia
        {
            get{return dia;}
            set{dia=value;}
        }


    

    }
}