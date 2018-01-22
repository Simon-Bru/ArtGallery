using System;

namespace ArtGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtGalery galery = new ArtGalery();
            galery.Initialize();
            galery.Sort();
            
            foreach (ArtPiece piece in galery.collection)  
            {
                Console.Write(piece.ToString()); 
            }
        }
    }
}
