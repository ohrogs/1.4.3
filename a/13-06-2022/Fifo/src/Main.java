public class Main {
    public static void main(String[] args) {
        Fifo<Integer> queue = createQueue(3);
        TryEnqueue(queue, 1);
        TryEnqueue(queue, 2);
        TryEnqueue(queue, 3);
        queue.printAll();
        System.out.println("stacco: " + queue.dequeue());
        queue.printAll();
        System.out.println("aggiungo 4 e stampo:");
        TryEnqueue(queue, 4);
        //TryEnqueue(queue, 5);
        queue.printAll();
        System.out.println("stacco: " + queue.dequeue());
        queue.printAll();
    }

    private static Integer tryDequeue(Fifo<Integer> queue)
    {
        return 10;
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
