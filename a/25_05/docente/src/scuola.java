public class scuola {

    //enum err = {ok, out of range};
    public docente[] elencoDocenti = null; //null aggiunto dal prof?
    public int dim, nextfree;

    private boolean isSorted;

    /*private void create()
    {
        for(int i = 0; i < dim; i++)
        {
            elencoDocenti[i] = new docente("empty", "empty", "empty", -1);
        }
    }*/

    public scuola(int pDIM) {
        dim = pDIM;
        elencoDocenti = new docente[dim]; //IMPORTANTE
        nextfree=0;
        isSorted=false;
    }

    public void printAlleta()
    {
        for (int i = 0; i < nextfree; i++)
        {
            System.out.println(elencoDocenti[i].getEta());
        }
    }

    private void sort()
    {
        for (int i = 0; i < nextfree-1; i++)
        {
            //System.out.println("debug" + i);
            if(elencoDocenti[i].getEta()>elencoDocenti[1+i].getEta())
            {
                //swap

                docente aux = elencoDocenti[i+1];
                elencoDocenti[i+1] = elencoDocenti[i];
                elencoDocenti[i] = aux;
                i=-1;
            }
        }
    }

    public void addDocente(docente pNuovo)
    {
        if(nextfree<dim)
        {
            elencoDocenti[nextfree++] = pNuovo;
            isSorted=false;
        }
        else
        {
            System.err.println("Index out of range...");
            return;
        }
    }

    public docente etaMinima()
    {
        if(dim<=0)
        {
            System.err.println("Index out of range...");
            return new docente("empty", "empty", "empty",0);
        }
        else if(!isSorted)
        {
            //sorting
            sort();
            return elencoDocenti[0];
        }
        else
            return elencoDocenti[0];
    }

    public String[] getAllEtaMinima()
    {
        String[] elenco = new String[nextfree];
        int count = 0;
        int factor = this.etaMinima().getEta();
        for (int i = 0; i < nextfree; i++)
        {
            elenco[i]="";
            if(elencoDocenti[i].getEta()==factor)
            {
                elenco[count++]=elencoDocenti[i].getCognome();

            }
        }
        return elenco;
    }

}
