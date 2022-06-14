public class Main {
    public static void main(String[] args) {
        Fifo<Integer> queue = createQueue(10);
        TryEnqueue(queue, 10);
        TryEnqueue(queue, 9);
        TryEnqueue(queue, 8);
        System.out.println(queue.dequeue());
        queue.printAll();
        queue.printRaw();

    }

    private static void TryEnqueue(Fifo<Integer> queue, Integer o)
    {
        try {
            queue.enqueue(o);
        }
        catch (wrongIndex e)
        {
            e.printStackTrace();
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }

    private static Fifo<Integer> createQueue(int dim)
    {
        Fifo<Integer> queue = null;
        try {
            queue = new <Integer>Fifo(dim);
        }
        catch (wrongIndex e)
        {
            e.printStackTrace();
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
        return queue;
    }
}
