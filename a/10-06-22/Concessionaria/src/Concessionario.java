import java.security.PublicKey;
import java.util.LinkedList;

public class Concessionario {
    private LinkedList<Motorino> parco;

    public Concessionario()
    {
        parco = new LinkedList<>();
    }

    public Motorino get(int i)
    {
        return parco.get(i);
    }

    public Motorino fetch(String plt)
    {
        for(Motorino x : parco)
        {
            if(x.getTarga().equals(plt))
                return x;
        }
        return new Motorino();
    }

    public void push(Motorino in)
    {
        if(!isIn(in))
            parco.addFirst(in);
    }

    public boolean isIn(Motorino in)
    {
        return parco.contains(in);
    }

    public boolean isIn(String plt)
    {
        for(Motorino x : parco)
        {
            if(x.getTarga().equals(plt))
                return true;
        }
        return false;
    }

    public void remove(Motorino in)
    {
        parco.remove(in);
    }

    public String getInfo(int i)
    {
        return parco.get(i).getInfo();
    }

}
