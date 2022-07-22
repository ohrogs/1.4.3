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
    @Override
    public String tree(String tabs)
    {
        return "";
    }

    @Override
    public void print(String prev) {
        System.out.println(prev+"\\"+name);
    }
}
