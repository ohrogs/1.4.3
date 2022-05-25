public class docente {
    private String nome, cognome, codice;
    private int eta;

    public docente(String pNome, String pCognome, String pCodice, int pEta)
    {
        nome = pNome;
        cognome = pCognome;
        codice = pCodice;
        eta = pEta;
    }

    public String getNome()
    {
        return nome;
    }

    public String getCognome()
    {
        return cognome;
    }

    public String getCodice()
    {
        return codice;
    }

    public int getEta()
    {
        return eta;
    }
}
