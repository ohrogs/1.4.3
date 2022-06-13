public class Stack {
    private Object []stack = null;
    private int currdim;

    public Stack()
    {
        stack = new Object[100];
        currdim = 0;
    }

    public Stack(int dim) throws Exception
    {
        if (dim<=0)
            throw new wrongIndex("Wrong index given");
        stack = new Object[dim];
        currdim = 0;
    }

    public void push(Object o) throws Exception
    {
        if(currdim >= stack.length)
            throw new notEnoughSpace("Not enough space in my brodero");

        stack[currdim++] = o;

    }

    public Object top()
    {
        return stack[currdim-1];
    }
    public Object pop()
    {
        Object ret = stack[currdim-1];
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
        stack = new Object[ogLen];
        currdim = 0;
    }

    public int getCurrdim() {
        return currdim;
    }
}
