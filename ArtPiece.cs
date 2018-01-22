using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Categories
{
    PAINTING, DRAWING , SCULPTURE 
}

namespace ArtGallery
{
    class ArtPiece : IComparable<ArtPiece>
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

        public int CompareTo(ArtPiece artP)
        {            
            return this.price.CompareTo(artP.price);
        }

        public override string ToString()
        {
            return "Title:\t"+m_title+"\nCategorie:\t"+m_categorie+"\nPrice:\t"+m_price+"\n";
        }
    }
}
