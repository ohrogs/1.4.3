public class ThrdDequeue implements Runnable{
    private Casello x;

    public ThrdDequeue(Casello x)
    {
        this.x = x;
    }

    @Override
    public void run() {
        x.dequeue();
    }
}
