public class ThrdEnqueue implements Runnable{
    private Casello c;
    private Veicolo v;

    public ThrdEnqueue(Casello c, Veicolo v)
    {
        this.c = c;
        this.v = v;
    }

    @Override
    public void run() {
        c.enqueue(v);
    }
}
