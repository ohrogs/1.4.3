public class Casello {
    private Fifo<Veicolo> coda;

    public Casello(){
        try {
            coda = new Fifo<>(200);
        }
        catch (Exception e){
            e.printStackTrace();
        }
    }

    public void enqueue(Veicolo o)
    {
        try {
            coda.enqueue(o);
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }

    public void dequeue()
    {
        coda.dequeue();
    }

    public Veicolo rdequeue()
    {
        return coda.dequeue();
    }



    public void printAll()
    {
        coda.printAll();
    }

}
