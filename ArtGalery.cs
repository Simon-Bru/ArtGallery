using System;
using System.Collections.Generic;

namespace ArtGallery 
{
    class ArtGalery : IArtSelect
    {
        private List<ArtPiece> m_Collection;

        public List<ArtPiece> collection // public property
        {
            get { return m_Collection; } // access control
            set { m_Collection = value; }
        }

        public void Initialize ()
        {
            this.collection = new List<ArtPiece>();

            this.collection.Add(new ArtPiece("Bold and Brash", Categories.PAINTING, 140));
            this.collection.Add(new ArtPiece("Le Brasseur", Categories.SCULPTURE, 40));
            this.collection.Add(new ArtPiece("L'Uomo Vitruviano", Categories.DRAWING, 200));
            this.collection.Add(new ArtPiece("PopArt", Categories.PAINTING, 105));
            this.collection.Add(new ArtPiece("Le Penseur", Categories.SCULPTURE, 180));
            this.collection.Add(new ArtPiece("Picasso Sketch", Categories.DRAWING, 193));
            this.collection.Add(new ArtPiece("Un Serpent Boa qui Dig�rait un �l�phant", Categories.DRAWING, 25));
            this.collection.Add(new ArtPiece("Mouton Dessin�", Categories.DRAWING, 78));
            this.collection.Add(new ArtPiece("Gernika", Categories.PAINTING, 135));
            this.collection.Add(new ArtPiece("Belongs in the Trash", Categories.PAINTING, 20));
            this.collection.Add(new ArtPiece("Davide de Bernini", Categories.SCULPTURE, 130));
            this.collection.Add(new ArtPiece("Badly Shapen Pot", Categories.SCULPTURE, 25));
        }

        public List<ArtPiece> ProcessArtPiece(IArtSelect artSelect)
        {
            return this.collection.FindAll(a => artSelect.Select(a));
        }

        public bool Select(ArtPiece piece) {
            return piece.price >= 150;
        }

        public void Sort()
        { 
            this.collection.Sort(delegate(ArtPiece x, ArtPiece y) 
            {
                    return x.CompareTo(y);
            });
        }
    }
}
