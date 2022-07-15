public abstract class Veicolo {
    protected int nposti;
    protected double interasse, peso, lunghezza;

    //public double portafoglio;

    public abstract double getPedaggioCost(double km, double prezzo);

    protected String toString(String info)
    {
        if (info == "")
            return
                    "\nNumero Posti: " + nposti +
                            "\nPeso: " + peso +
                            "\nLunghezza: " + lunghezza +
                            "\nInterasse: " + interasse;
        else
            return
                    "\nNumero Posti: " + nposti +
                            "\nPeso: " + peso +
                            "\nLunghezza: " + lunghezza +
                            "\n" + info +
                            "\nInterasse: " + interasse;
    }

    public int getNposti() {
        return nposti;
    }


    public double getInterasse() {
        return interasse;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }
}
