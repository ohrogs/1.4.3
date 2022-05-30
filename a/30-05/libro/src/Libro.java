public class Libro {
    private String titolo;
    private Autore autore;
    private double prezzo;

    public Libro()
    {
        titolo = "il manifesto";
        autore = new Autore();
        prezzo = 0.0;
    }

    public Libro(Autore a, String titolo, double prezzo)
    {
        autore = a;
        this.titolo = titolo;
        this.prezzo = prezzo;
    }

    public Libro(String nome, String cognome, String dataNasctia, String titolo, double prezzo)
    {
        autore = new Autore(nome, cognome, dataNasctia);
        this.titolo = titolo;
        this.prezzo = prezzo;
    }

    public Libro(Libro l)
    {
        this.titolo = l.titolo;
        this.autore = l.autore;
        this.prezzo = l.prezzo;
    }

    public String getTitolo() {
        return titolo;
    }

    public Autore getAutore() {
        return autore;
    }

    public String getStringAutore()
    {
        return autore.congome + " " +autore.congome;
    }

    public double getPrezzo() {
        return prezzo;
    }

    public void printAll()
    {
        System.out.println(autore.congome + ", " + autore.nome + ", " + titolo + ", " + prezzo);
    }
}
