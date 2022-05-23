public class Main
{
    public static void main(String[] args)
    {
        motorino n1 = new motorino("Blue", "Malaguti", "Phantom F12", 999,1224);
        n1.ignition();
        boolean k;
        do
        {
            n1.accelerate(20);
            System.out.println(n1.getSpeed());
            n1.shutDown();
            k = n1.onOff;
        }while(k);

    }
}