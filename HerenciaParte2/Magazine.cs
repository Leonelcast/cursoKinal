using System;
using System.Collections.Generic;

namespace HerenciaParte2
{
    public class Magazine : Publication
    {
        private int id;
        public Magazine() : base() { }
        public Magazine(string title, DateTime date, string editorial) : base(title, date, editorial)
        {

        }
        public int Id
        {
            get { return id; }
        }
        public override string ToString()
        {// interpolacion $
            return $"Magazine: {this.Title}" ;
        }
        public static List<Magazine> makeMagazineList()
        {
            return null;
        }

    }


}