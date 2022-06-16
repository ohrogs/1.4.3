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
        checkN = b>=t;
        return b>=t;
    }

    private void scale()
    {
        for (int i = t; i>b; i--)
        {
            queue[i] = queue[i--];
        }

    }

    public void enqueue(T o) throws Exception
    {
        if (b == queue.length-1 || t == queue.length-1)
            throw new maxDimReached("Max array dimension reached");
        /*scale();
        queue[++b] = o;

        //qui devo scalare ma la scalata va fatta da b fino a t non da un altra parte e b deve seguire t e non annullare nulla*/
        //scale();
        queue[t++]=o;
    }

    public T dequeue()
    {
        T ret = queue[b];
        queue[b] = null;
        b++;
        //scale();
        //anche qui devo ricopiare tutto in su perche la coda viene avanti
        return ret;
    }

    public void printAll()
    {
        for (int i = b; i<t; i++)
        {
            System.out.print(queue[i] + " ");
        }
        System.out.println("");
    }

    public void printRaw()
    {
        for (T o : queue)
        {
            System.out.print(o + " ");
        }
        System.out.println("");
    }

}
