public abstract class Figura {
    protected int nlati;

    protected abstract double Area();
    protected abstract double Perimetro();

    protected String ToString()
    {
        return  "Nome: " + this.getClass().getSimpleName() + "\nNlati:" + String.valueOf(nlati);
    }
}
