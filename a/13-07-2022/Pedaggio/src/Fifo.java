public class Fifo<T> {
    protected T []queue = null;
    private int b,t, contObj; //b bottom, t top
    private  boolean begin; //first try

    public Fifo(int dim) throws Exception
    {
        if(dim<=0)
            throw new wrongIndex("Wrong index Given");
        b = 0;
        t = 0;
        contObj = 0;
        begin=true;
        queue = (T[]) new Object [dim];
    }

    private boolean check()
    {
        return b == t;
    }

    private void scale()
    {
        for (int i = t; i > b; i--)
        {
            queue[i] = queue[i--];
        }

    }

    private void reset()
    {
        int dim = queue.length;
        queue = null;
        b = 0;
        t = 0;
        contObj = 0;
        begin=true;
        queue = (T[]) new Object [dim];

    }

    public void enqueue(T o) throws Exception
    {
        if (queue[b] != null)
            throw new maxDimReached("Max array dimension reached");
        begin=false;
        queue[b]=o;
        b=(b+1) % queue.length;
        contObj++;
    }

    public T dequeue()
    {
        T ret = queue[t];
        queue[t] = null;
        t = (t+1) % queue.length;
        contObj--;
        /*if (check() && !begin) //resetto se ho finito la coda
            reset();*/
        return ret;
    }

    /*public void printAll()
    {
        //System.out.println("queue.lenght= " + queue.length);
        if (b>=t)
        {
            System.err.println("stampo da t = "+ t + " a b= "+ b);
            for (int i = t; i <= b; i++)
            {
                System.out.print(queue[i] + " ");
            }
            System.out.println("");
        }
        else
        {
            for (int i = t; i < queue.length; i++)
            {
                System.out.print(queue[i] + " ");
            }
            for (int i = 0; i <= b; i++)
            {
                System.out.print(queue[i] + " ");
            }
            System.out.println("");
        }
    }*/


    /*public void printAll()
    {

        for (int i = t; i < b; i++)
        {
            System.out.print(queue[(t+i)%queue.length] + " ");
        }
        System.out.println("");
    }*/

    public void printAll()
    {

        for (int i = 0; i < contObj; i++)
        {
            System.out.print(queue[(t+i)%queue.length] + "\n");
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

    public int getB() {
        return b;
    }

    public void setB(int b) {
        this.b = b;
    }

    public int getT() {
        return t;
    }

    public void setT(int t) {
        this.t = t;
    }
}
