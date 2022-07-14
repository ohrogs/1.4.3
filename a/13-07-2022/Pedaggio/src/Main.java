import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        /*Auto auto = new Auto(1200, 2000, 2400, 5);
        //System.out.println(auto);
        Camion camion = new Camion(1200, 5000, 4600, 3);
        //System.out.println(camion);
        Moto moto = new Moto(1200, 1200, 1250, 2);
        //System.out.println(moto);
        Pullman pullman = new Pullman(1200, 4000, 4400, 50);
        //System.out.println(pullman);
        //System.out.println("");

        Casello c = new Casello();
        c.enqueue(auto);
        c.enqueue(moto);
        c.enqueue(camion);
        c.enqueue(pullman);
        System.out.println("Stampa di tutto: ");
        c.printAll();
        System.out.println("Stampa dopo deuqueue");
        c.dequeue();
        c.printAll();*/


        Casello c = new Casello();
        Thread equeue = new Thread(new ThrdEnqueue(c, buildVeicoli()));
        Thread dequeue = new Thread(new ThrdDequeue(c));

        equeue.start();
        dequeue.start();
    }

    private static ArrayList<Veicolo> buildVeicoli()
    {
        ArrayList<Veicolo> ret = new ArrayList<>();
        ret.add(new Auto(1800, 1900, 2000, 5));
        ret.add(new Auto(800, 1200, 1500, 4));
        ret.add(new Pullman(1200, 4000, 4400, 50));
        ret.add(new Moto(1200, 1200, 1250, 2));
        ret.add(new Camion(1200, 5000, 4600, 3));
        return ret;

    }
}
