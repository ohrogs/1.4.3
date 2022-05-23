class Rectangle
{
    //attributi
    private double lenght;
    private double height;

    //metodi

    //costruttore
    public Rectangle(double lenghtIn, double heightIn)
    {
        lenght = lenghtIn;
        height = heightIn;
    }

    public double getLenght()
    {
        return lenght;
    }

    public double getHeight()
    {
        return height;
    }

    public void setLenght(double a)
    {
        lenght = a;
    }

    public void setHeight(double a)
    {
        height = a;
    }

    public double perimetro()
    {
        return lenght+height;
    }

    public double area()
    {
        return lenght*height;
    }
}