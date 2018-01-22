using System;

class ArtGalery : IArtSelect
{
    public bool Select(ArtPiece piece) {
        if(this.m_Collection.contains(piece)) {

        }
        return true;

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
