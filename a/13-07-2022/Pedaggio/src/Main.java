public class Main {
    public static void main(String[] args) {
        Auto auto = new Auto(1200, 2000, 2400, 5);
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
        c.printAll();
    }
}
