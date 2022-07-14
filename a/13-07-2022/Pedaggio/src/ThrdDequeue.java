import java.time.Instant;
import java.util.Date;

public class ThrdDequeue implements Runnable{
    private Casello x;

    public ThrdDequeue(Casello x)
    {
        this.x = x;
    }

    @Override
    public void run() {
        System.out.println("ora: " + Date.from(Instant.now()) + " Dequeue restituisce");
        Veicolo check = x.rdequeue();
        if (check != null)
            System.out.println(check);
        try
        {
            Thread.sleep(2000);
        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
    }
}
