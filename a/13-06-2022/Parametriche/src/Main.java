public class Main {
    public static void main(String[] args) {
        Stack<Integer> stack = null;
        try {
            stack = new Stack<Integer>(100);
            //stack1 = new Stack<Integer>(-1);
        }
        catch (wrongIndex e)
        {
            e.printStackTrace();
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
        finally {
            System.out.println("Creazione stack eseguita correttamente");
        }
        //stack.push("ciao");
        Fill(stack, 12);
        Empty(stack);
        Fill(stack, 10);
        stack.clean();
        Empty(stack);
    }

    private static void Empty(Stack c)
    {
        int k = c.getCurrdim()-1;
        for(int i = 0; i < k; i++)
        {
            System.out.println(c.pop());
        }
    }

    private static void Fill(Stack<Integer> stack, int dim)
    {
        try {
            for (int i = 0; i<dim; i++)
            {
                stack.push(i);
            }
            //stack.push("string");
        }

        catch (notEnoughSpace e)
        {
            e.printStackTrace();
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
        finally {
            System.out.println("No problem");
        }
    }
}
