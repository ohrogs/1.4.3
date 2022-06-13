public class Stack <T>{
    private T []stack = null;
    private int currdim;

    public Stack()
    {
        stack = (T[]) new Object [999];
        currdim = 0;
    }

    public Stack(int dim) throws Exception
    {
        if (dim<=0)
            throw new wrongIndex("Wrong index given");
        stack = (T[]) new Object [dim];
        currdim = 0;
    }

    public void push(T o) throws Exception
    {
        if(currdim >= stack.length)
            throw new notEnoughSpace("Not enough space in my brodero");

        stack[currdim++] = o;

    }

    public T top()
    {
        return stack[currdim-1];
    }
    public T pop()
    {
        T ret = stack[currdim-1];
        stack[currdim-1] = null;
        currdim--;
        return ret;
    }

    public void clean()
    {
        if(currdim == 0)
            return;
        int ogLen= stack.length;
        stack = null;
        stack = (T[]) new Object [ogLen];
        currdim = 0;
    }

    public int getCurrdim() {
        return currdim;
    }
}
