import java.util.Scanner;

public class motorino
{
    private boolean antith;
    public String color;
    public String brand;
    public String model;

    public boolean onOff;
    private int speed, maxspeed, pin;

    public motorino(String colorIn, String brandIn, String modelIn, int maxspeedIn, int pinIn)
    {
        maxspeed=maxspeedIn;
        speed=0;
        color=colorIn;
        model = modelIn;
        brand=brandIn;
        antith = true;
        onOff = false;
        pin=pinIn;
    }

    public int getSpeed()
    {
        return speed;
    }

    public void accelerate(int delta)
    {
        if(!onOff)
        {
            System.err.println("Il motorino é spento...");
            return;
        }
        speed+=delta;
        if(speed>maxspeed)
            speed=maxspeed;
        else if (speed<1)
            speed = 0;
    }

    public boolean disAntith(double extPin)
    {
        if(extPin==pin)
        {
            antith=false;
            return true;
        }

        else
        {
            System.err.println("Il pin é errato...");
            return false;
        }

    }

    public void shutDown()
    {
        speed=0;
        antith=true;
        onOff=false;
    }


    public void ignition()
    {
        if(onOff)
        {
            System.err.println("Il motorino é gia acceso...");
        }
        else if(antith)
        {
            Scanner key = new Scanner(System.in);
            System.out.println("inserire il pin");
            onOff = disAntith(key.nextInt());
        }
        else if(!antith)
        {
            onOff=true;
        }
    }
}
