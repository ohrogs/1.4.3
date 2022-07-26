public class ThreadProxy implements Runnable{

    private Subject p;

    static private int progr = 0;
    private int n;

    public ThreadProxy(RealSubject subject)
    {
        p = new Proxy(subject);
        n = ++progr;
    }

    @Override
    public void run() {
        while (true)
        {
            System.out.println("Thread " + n + " restituisce: " + p.getData());
            try {
                Thread.sleep(2000);
            }
            catch (Exception ex)
            {
                ex.printStackTrace();
            }
        }
    }
}
