import java.time.Instant;

public class Proxy implements Subject{
    Subject subject;
    int Data;
    long last;

    public Proxy(Subject subject)
    {
        this.subject = subject;
        Data = subject.getData();
        last = Instant.now().getEpochSecond();
    }

    @Override
    public int getData() {
        if(Instant.now().getEpochSecond() - last > 5)//caching
            refresh();
        return Data;
    }

    private void refresh()
    {
        Data = subject.getData();
        last = Instant.now().getEpochSecond(); //restituisce il tempo in ms del sistema come long
    }
}
