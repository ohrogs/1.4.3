public class File implements Element{ //LEAF
    protected String name;

    public File(String name)
    {
        this.name = name;
    }

    @Override
    public String ls()
    {
        return name;
    }
}
