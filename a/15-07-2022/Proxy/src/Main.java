public class Main {
    public static void main(String[] args) {
        Proxy proxy = new Proxy(new RealSubject());
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
        }
    }
}