public class elenco {
    private String[] cognomi = null;
    public int maxDim=999, DIM, nextfree;

    public elenco(int pDim)
    {
        cognomi = new String[maxDim];
        DIM = pDim;
        nextfree = 0;
    }

    public void addCognome(String a)
    {
        if (nextfree < maxDim && nextfree >= DIM)
        {
            DIM += 10;
        }
        else if (nextfree == maxDim)
        {
            System.err.println("array is full...");
            return;
        }
        cognomi[nextfree++]=a;
        return;
    }

    public String getPos(int i)
    {
        if (i<nextfree && i >= 0)
            return cognomi[i];
        else
        {
            return "error";
        }
    }

    public void printAll()
    {
        for (int i = 0; i < nextfree; i++)
        {
            System.out.println(cognomi[i]);
        }
    }

}
