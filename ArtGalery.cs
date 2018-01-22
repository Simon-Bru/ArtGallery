using System;

class ArtGalery : IArtSelect
{
    public bool Select(ArtPiece piece) {
        if(this.m_Collection.contains(piece)) {

        }
        return true;
    }
}
