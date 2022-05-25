import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner key = new Scanner(System.in);
        System.out.print("Inserisca il numero di docenti>");

        scuola sestri = new scuola(key.nextInt());
        sestri.addDocente(new docente("a", "a", "1", 200));
        sestri.addDocente(new docente("b", "b", "2", 199));
        sestri.addDocente(new docente("c", "c", "3", 1));
        sestri.addDocente(new docente("d", "d", "4", 1));
        sestri.addDocente(new docente("e", "e", "5", 1));
        //System.out.println(sestri.elencoDocenti[0].getCognome());
        sestri.printAlleta();
        System.out.println("etá minima rilevata = " + sestri.etaMinima().getEta());
        sestri.printAlleta();
        String []elenco = sestri.getAllEtaMinima();
        System.out.println("procedo a stampare l'elenco:");
        for (int i = 0; i < sestri.nextfree; i++)
        {
            System.out.println(elenco[i]);
        }
    }
}