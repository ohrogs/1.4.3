public class Motorino {
    private String targa, modello,ntelaio;
    private int cilindrata;
    Propirietario propirietario;

    public Motorino()
    {
        cilindrata = 1048;
        targa = "AA000AA";
        modello = "Honda sh125i";
        ntelaio = "Null bike, hai fatto una belinata BELANDI AMICI DI STRISCIA";
        propirietario = new Propirietario();
    }

    public Motorino(String targa, String modello, String ntelaio, String nomeproprietario, int cilindrata)
    {
        this.targa = targa;
        this.modello = modello;
        this.ntelaio = ntelaio;
        this.cilindrata = cilindrata;
        propirietario = new Propirietario(nomeproprietario);
    }

    public String getInfo()
    {
        return modello + ", " + cilindrata + ", " + targa + ", " + ntelaio;
    }


    public void setCilindrata(int cilindrata) {
        this.cilindrata = cilindrata;
    }

    public int getCilindrata() {
        return cilindrata;
    }

    public void setModello(String modello) {
        this.modello = modello;
    }

    public String getModello() {
        return modello;
    }

    public String getTarga() {
        return targa;
    }

    public void setNtelaio(String ntelaio) {
        this.ntelaio = ntelaio;
    }

    public String getNtelaio() {
        return ntelaio;
    }

    public void setTarga(String targa) {
        this.targa = targa;
    }
}
