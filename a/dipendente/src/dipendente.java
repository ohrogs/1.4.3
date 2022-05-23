public class dipendente {
    private float basic, extra;
    public String mat;

    public dipendente(String pMat, float pPaga, float pExtra)
    {
        mat=pMat;
        basic=pPaga;
        extra=pExtra;
    }
    public float getBasic()
    {
        return basic;
    }

    public float getPay(int h)
    {
        return basic*(float)h;
    }

    public float getExtra(int h)
    {
        return extra*(float)h;
    }

    public void stampa()
    {
        System.out.println("Matricola = "+ mat +" Stipendio Base = " + basic + " Stipendio straordinari " + extra);
    }
}
//hai classe dipendente con matricola stringa, stipendio e straordinario
//straordinario è il numero di soldi che si prendono per ora
//getpaga getstipendio