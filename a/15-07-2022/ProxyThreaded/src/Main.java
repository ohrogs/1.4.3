public class Main {
    public static void main(String[] args) {
        /*Proxy proxy = new Proxy(new RealSubject());
        while(true)
        {
            System.out.println(proxy.getData());
            try {
                Thread.sleep(2000);
            }
            catch (Exception ex)
            {
                ex.printStackTrace();
            }
        }*/
        RealSubject utente1 = new RealSubject();
        RealSubject utente2 = new RealSubject();
        RealSubject utente3 = new RealSubject();
        Thread ThreadUtente1 = new Thread(new ThreadProxy(utente1));
        Thread ThreadUtente2 = new Thread(new ThreadProxy(utente1));
        Thread ThreadUtente3 = new Thread(new ThreadProxy(utente1));

        ThreadUtente1.start();
        ThreadUtente2.start();
        ThreadUtente3.start();
    }
}