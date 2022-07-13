public class Camion extends Veicolo{
    public Camion(double peso, double interasse, double lunghezza, int nposti) {
        this.interasse = interasse;
        this.lunghezza = lunghezza;
        this.peso = peso;
        this.nposti = nposti;
    }

    @Override
    public double getPedaggioCost(double km, double prezzo) {
        return km * prezzo * peso;
    }

    public String toString()
    {
        return super.toString("");
    }
}
