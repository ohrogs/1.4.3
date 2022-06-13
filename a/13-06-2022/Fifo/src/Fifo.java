public class Fifo<T> {
    private T []queue = null;
    private int b,t; //b bottom, t top
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

    private void scale()
    {

    }

    public void enqueue(T o) throws Exception
    {
        if (b == queue.length-1 || t == queue.length-1)
            throw new maxDimReached("Max array dimension reached");
        if(b==0 && t==0)
        {
            queue[0]=o;
        }
        else
        {
            queue[++t]=o;
        }
    }

    public T dequeue()
    {
        T ret = queue[t];
        queue[t--]=null;
        return ret;
    }

}
