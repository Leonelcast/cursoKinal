using System;
namespace HerenciaParte2
{
    public abstract class Publication
    {
        //propfull
        private string title;
        private DateTime date;
        private string editorial;
        private string[] autores;

        public Publication() { }
        public Publication(string title, DateTime date, string editorial)
        {
            this.Title = title;
            this.Date = date;
            this.Editorial = editorial;

        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        public string[] Autores
        {
            get { return autores; }
            set { autores = value; }
        }
    }
}