public class ElencoLibri {
    private Libro[] elenco;
    public int nextfree, maxDim;

    public ElencoLibri(int dim)
    {
        elenco = new Libro[dim];
        nextfree = 0;
        maxDim = dim;
    }

    public ElencoLibri()
    {
        elenco = new Libro[999];
        nextfree = 0;
        maxDim = 999;
    }

    public void append(Libro l)
    {
        elenco[nextfree++]=l;
    }

    public Libro read(int i)
    {
        return elenco[i];
    }

    public void printElenco()
    {
        for(int i = 0; i < nextfree; i++)
        {
            elenco[i].printAll();
        }
    }
}
