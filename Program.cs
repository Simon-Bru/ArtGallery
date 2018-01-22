using System;

namespace ArtGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtGalery galery = new ArtGalery();
            galery.Initialize();

            /*
             * Gallery sorting
             */
            galery.Sort();
            foreach (ArtPiece piece in galery.collection)  
            {
                Console.Write(piece.ToString()); 
            }

            /*
             * Processing according to nested classes
             */
            Console.Write("\n\nSCULTURES UNDER 100\n");
            foreach (ArtPiece piece in galery.ProcessArtPiece(new SculptureUnder100()))  
            {
                Console.Write(piece.ToString()); 
            }

            Console.Write("\n\nPAINTINGS ABOVE 100\n");
            foreach (ArtPiece piece in galery.ProcessArtPiece(new PaintingOver100()))  
            {
                Console.Write(piece.ToString()); 
            }

            Console.Write("\n\nART GALLERY ABOVE 150\n");
            foreach (ArtPiece piece in galery.ProcessArtPiece(galery))
            {
                Console.Write(piece.ToString()); 
            }

        }
    }

    class SculptureUnder100 : IArtSelect
    {
        public bool Select(ArtPiece piece) {
            return piece.price < 100 && piece.categorie == Categories.SCULPTURE;
        }
    }

    class PaintingOver100 : IArtSelect
    {
        public bool Select(ArtPiece piece) {
            return piece.price < 100 && piece.categorie == Categories.PAINTING;
        }
    }
}
