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

        public ArtGalery Initialize ()
        {
            this.m_Collection = new List<ArtPiece>();
            return this;
        }

        public ArtPiece ProcessArtPiece()
        {
            return new ArtPiece();
        }

        public bool Select(ArtPiece piece) {
            return piece.price >= 150;
        }

    }
}
