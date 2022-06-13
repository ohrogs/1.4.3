public class Main {
    public static void main(String[] args) {
        try {
            g();
        }
        catch (Exception e)
        {
            System.err.println(e.getCause());
            System.err.println(e.getMessage());
            e.printStackTrace();
        }
    }

    private static void f() throws Exception{
        throw new Exception("viene da f");
    }

    private static void g() throws Exception
    {
        try {
            f();
        }
        catch (Exception e)
        {
            throw new Exception("viene da g", e);
        }

    }
}
