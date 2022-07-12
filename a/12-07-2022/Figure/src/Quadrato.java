public class Quadrato extends Figura{

    private double l;

    public Quadrato()
    {
        nlati = 4;
        l = 0.0;
    }

    public double Area()
    {
        return l * l;
    }

    public double Perimetro()
    {
        return l * 4;
    }

    @Override
    public String ToString()
    {
        return super.ToString() +
                "\nLato: " + l +
                "\nArea: " + Area() +
                "\nPerimetro: " + Perimetro();
    }
}
