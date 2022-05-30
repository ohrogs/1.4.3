public class ElencoAutori {
    private Autore[] elenco;
    public int nextfree, maxDim;

    public ElencoAutori(int dim)
    {
        elenco = new Autore[dim];
        nextfree = 0;
        maxDim = dim;
    }

    public ElencoAutori()
    {
        elenco = new Autore[999];
        nextfree = 0;
        maxDim = 999;
    }

    public void append(Autore a)
    {
        elenco[nextfree++] = a;
    }

    public Autore read(int i)
    {
        return elenco[i];
    }

    public void printElenco()
    {
        for(int i = 0; i < nextfree; i++)
        {
            elenco[i].printAutore();
        }
    }
}
