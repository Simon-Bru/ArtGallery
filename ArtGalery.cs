using System;

class ArtGalery
{
    private List<ArtPiece> m_Collection; 

    public int data // public property
    {
        get { return m_data; } // access control
        set { m_data = value; }
    }

    public ArtGalery Initialize ()
    {
        List<ArtPiece> m_Collection = new List<ArtPiece>();
    }

    public Art ProcessArtPiece()
    {
        
    }
}
