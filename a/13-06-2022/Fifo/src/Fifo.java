public class Fifo<T> {
    private T []queue = null;
    private int b,t; //b tiene conto della testa della coda, t del retro
    private  boolean checkN;

    public Fifo(int dim) throws Exception
    {
        if(dim<=0)
            throw new wrongIndex("Wrong index Given");
        b = 0;
        t = 0;
        checkN=true;
        queue = (T[]) new Object [dim];
    }

    private boolean check()
    {
        return b>=t;
    }

    public void enqueue(T o) throws Exception
    {
        if (b == queue.length-1 || t == queue.length-1)
            throw new maxDimReached("Max array dimension reached");
        if(b==0 && t==0)
        {
            queue[0]=o;
        }
        else if(b>0 && t==0)
        {
            queue[1]=queue[0];
            queue[0]=o;
            b++;
        }
        else
        {
            
        }
    }

}
