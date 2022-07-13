public class Auto extends Veicolo {
    private String categoria;

    public Auto(double peso, double interasse, double lunghezza, int nposti) {
        this.interasse = interasse;
        this.lunghezza = lunghezza;
        this.peso = peso;
        this.nposti = nposti;
        if(lunghezza/100.0 < 4.0)
        {
            categoria = "Piccole";
        }
        else if(lunghezza/100.0 < 4.5 && lunghezza/100.0 >= 4.0)
        {
            categoria = "Medie";
        }
        else
        {
            categoria = "Grandi";
        }
    }

    public String getCategoria() {
        return categoria;
    }

    @Override
    public double getPedaggioCost(double km, double prezzo) {
        return km * prezzo * lunghezza/100;
    }


    public String toString()
    {
        return super.toString(categoria);
    }
}
