public class Libreria {
    ElencoLibri libreria;

    public Libreria(int dim)
    {
        libreria = new ElencoLibri(dim);
    }

    public boolean isIn(Libro l)
    {
        for (int i = 0; i < libreria.nextfree; i++)
        {
            if(libreria.read(i).getAutore().nome.equals(l.getAutore().nome) && libreria.read(i).getAutore().congome.equals(l.getAutore().congome))
            {
                return true;
            }
        }
        return false;
    }

    public void add(Libro l)
    {
        if(isIn(l))
        {
            return;
        }
        libreria.append(l);

    }

    public ElencoLibri fetch(double price, String autoreNome, String autoreCognome)
    {
        ElencoLibri ris = new ElencoLibri(libreria.nextfree);
        for (int i = 0; i < libreria.nextfree; i++)
        {
            if (libreria.read(i).getPrezzo() < price && libreria.read(i).getAutore().nome.equals(autoreNome) && libreria.read(i).getAutore().congome.equals(autoreCognome))
            {//se libreria.libro.prendiautore.cognome.éuguale?
                ris.append(libreria.read(i));
            }
        }
        return ris;
    }

    public ElencoLibri fetchAutore(Autore autore)
    {
        ElencoLibri ris = new ElencoLibri(libreria.nextfree);
        for (int i = 0; i < libreria.nextfree; i++)
        {
            if (autore.congome.equals(libreria.read(i).getAutore().congome) && autore.nome.equals(libreria.read(i).getAutore().nome))
            {
                ris.append(libreria.read(i));
            }
        }
        return ris;
    }

    public void printAll()
    {
        libreria.printElenco();
    }
}
