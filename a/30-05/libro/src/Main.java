public class Main {
    public static void main(String[] args) {
        Libreria lib1 = new Libreria(4);
        lib1.add(new Libro(new Autore("frank", "herbert", "non lo so"), "dune", 9.99));
        lib1.add(new Libro(new Autore("frank", "herbert", "non lo so"), "il messia di dune", 19.99));
        lib1.add(new Libro(new Autore("frank", "herbert", "non lo so"), "dune 3?", 199.99));
        lib1.add(new Libro());
        lib1.printAll();
        ElencoLibri esito = lib1.fetchAutore(new Autore("frank", "herbert", "non lo so"));
        System.out.println("esito print fetchautore");
        esito.printElenco();
        System.out.println("esito print fetch");
        esito = lib1.fetch(20.0, "frank", "herbert");
        esito.printElenco();
        System.out.println(lib1.isIn(new Libro()));
    }
}
