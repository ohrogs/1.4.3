public class Main {
    public static void main(String[] args) {

        PrintAny(a);
    }

    private static void PrintAny(SomeAble s)
    {
        System.out.println(s.Some());
    }

    private static void PrintAny(AnyAble a)
    {
        System.out.println(a.Any());
    }
}
