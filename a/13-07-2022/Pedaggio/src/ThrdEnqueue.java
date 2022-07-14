import com.sun.source.tree.TryTree;

import java.util.ArrayList;
import java.util.concurrent.ThreadLocalRandom;

public class ThrdEnqueue implements Runnable{
    private Casello c;

    private ArrayList<Veicolo> Arrivi;

    public ThrdEnqueue(Casello c, ArrayList<Veicolo> Arrivi)
    {
        this.c = c;
        this.Arrivi = Arrivi;
    }

    @Override
    public void run() {
        while (true)
        {
            c.enqueue(Arrivi.get(ThreadLocalRandom.current().nextInt(0, Arrivi.size())));
            try
            {
                Thread.sleep(1000);
            }
            catch (Exception ex)
            {
                ex.printStackTrace();
            }
        }
    }
}
