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
        private readonly string m_title=null;
        private readonly Categories m_categorie;
        private readonly int m_price;

        public string title
        {
            get { return m_title; }
        }

        public Categories categorie
        {
            get { return m_categorie; }
        }


        public int price
        {
            get { return m_price; }
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
