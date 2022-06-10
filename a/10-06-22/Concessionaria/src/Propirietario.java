public class Propirietario {
    private String NomeLegale;

    public Propirietario()
    {
        this.NomeLegale = "null nullini";
    }

    public Propirietario(String NomeLegale)
    {
        this.NomeLegale = NomeLegale;
    }

    public String getNomeLegale() {
        return NomeLegale;
    }

    public void setNomeLegale(String nomeLegale) {
        NomeLegale = nomeLegale;
    }
}
