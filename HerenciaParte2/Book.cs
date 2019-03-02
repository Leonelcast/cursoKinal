using System;
using System.Collections.Generic;
namespace HerenciaParte2
{
    public class Book : Publication, Ivisualizable
    {
        private int id;
        private string isbn;
        private bool readed;
        private int timeReaded;
        public Book() :base(){ }
        public Book(string title, DateTime date, string editorial, string[] autores) : base(title, date, editorial)
        {
            this.Autores = autores;
        }
        public int Id
        {
            get { return id; }
        }
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public bool Readed
        {
            get { return readed; }
            set { readed = value; }
        }
        public int TimeReaded
        {
            get { return timeReaded; }
            set { timeReaded = value; }
        }

        public DateTime startToSee(DateTime dateI)
        {
            return dateI;
        }

        public void stopToSee(DateTime dateI, DateTime dateF)
        {
            this.TimeReaded = dateF.Second - dateI.Second;
        }

        public override string ToString()
        {
            return $"Book:{this.Isbn}{this.Title}";
        }
        public static List<Book> makeBookList()
        {
            return null;
        }



    }
}