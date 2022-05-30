import java.util.ArrayList;

public class Libreria {
    //ElencoLibri libreria;
    ArrayList<Libro> libreria;

    public Libreria()
    {
        libreria = new <Libro>ArrayList();
    }

    public boolean isIn(Libro l)
    {
        for(Libro k : libreria) {
            if (k.isEqual(l)) {
                return true;
            }
        }
        return false;
    }

    public void add(Libro l)
    {
        if(this.isIn(l))
        {
            return;
        }
        libreria.add(l);
    }

    public ArrayList<Libro> fetch(double price, String autoreNome, String autoreCognome)
    {
        ArrayList<Libro> ris = new <Libro>ArrayList();
        for (int i = 0; i < libreria.size(); i++)
        {
            if (libreria.get(i).getPrezzo() < price && libreria.get(i).getAutore().nome.equals(autoreNome) && libreria.get(i).getAutore().congome.equals(autoreCognome))
            {//se libreria.libro.prendiautore.cognome.éuguale?
                ris.add(libreria.get(i));
            }
        }
        return ris;
    }

    public ArrayList<Libro>  fetchAutore(Autore autore)
    {
        ArrayList<Libro> ris = new <Libro>ArrayList();
        for (int i = 0; i < libreria.size(); i++)
        {
            if (autore.congome.equals(libreria.get(i).getAutore().congome) && autore.nome.equals(libreria.get(i).getAutore().nome))
            {
                ris.add(libreria.get(i));
            }
        }
        return ris;
    }

    public void printAll()
    {
        for(Libro l : libreria)
        {
            l.printAll();
        }
    }
}
