import java.time.Instant;
import java.util.Date;
import java.util.concurrent.ThreadLocalRandom;

public class RealSubject implements Subject{
    public int getData()
    {
        int ret = ThreadLocalRandom.current().nextInt(0, 110);
        //System.out.println("Ore: " + Date.from(Instant.now()) + " Realsubject restituisce " + ret);
        return ret;
    }
}
