using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class ArtPiece:IComparable
    {
        private string m_title=null;
        private Categories m_categorie;
        private int m_price;

        public string title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        public Categories categorie
        {
            get { return m_categorie; }
            set { m_categorie = value; }
        }


        public int price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        public ArtPiece(string title, Categories categorie,int price)
        {
            m_title = title;
            m_categorie = categorie;
            m_price = price;

        }

        public int CompareTo(object obj)
        {
            return price.CompareTo(obj);
        }

        public override string ToString()
        {
            return "title:"+m_title+" categorie:"+m_categorie+" price:"+m_price;
        }
    }
}
