public class Autore {
    public String nome, congome, dataNascita;


    public Autore()
    {
        nome = "Karl";
        congome = "Marx";
        dataNascita = "ma a me che cosa me ne frega";
    }

    public Autore(String nome, String cognome, String dataNasctia)
    {
        this.nome = nome;
        this.congome = cognome;
        this.dataNascita = dataNasctia;
    }

    public void printAutore()
    {
        System.out.println(congome + ", " + nome);
    }

    //pensare a un array classe che abbia i libri di un autore solo linkati;

}
