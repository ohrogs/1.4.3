public class Main {
    public static void main(String[] args) {
        Concessionario appari = new Concessionario();
        appari.push(new Motorino());
        appari.push(new Motorino("XX999XX", "Yamaha R1M", "XX999XX", "Piermenti Sfracellozzi", 1000));
        appari.push(new Motorino("AA999AA", "Yamaha tmax", "AA999AA", "Piermenti Sfracellozzi", 600));
        System.out.println(appari.isIn("AA999AA"));
        System.out.println(appari.get(1).getInfo());

    }

    private static void printMenu()
    {
        System.out.println("1 Inserire motorino");
        System.out.println("2 Visualizzazione");
        System.out.println("3 Fetchare un motorino tramite targa");
        System.out.println("4 Inserire 10 alunni generati progressivamente");
        System.out.println("0 o altro per uscire");
    }
}
