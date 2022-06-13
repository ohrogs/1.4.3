public class Main {
    public static void main(String[] args) {
        Stack stack = null;
        try {
            stack = new Stack(100);
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

    private static void Fill(Stack stack, int dim)
    {
        try {
            for (int i = 0; i<dim; i++)
            {
                stack.push(i);
            }
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
