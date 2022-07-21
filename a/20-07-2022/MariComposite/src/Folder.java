import java.util.LinkedList;

public class Folder implements Element{ //COMPOSITE

    private String name;
    private LinkedList<Element> children;

    public Folder(String name)
    {
        this.name = name;
        children = new LinkedList<>();
    }

    @Override
    public String ls()
    {
        String ret = name;
        //tirare qualcosa fuori dal cappello
        for (Element e:children) {
            if(e.getClass().getSimpleName().equals("Folder"))
                System.out.println("");
            ret += "\\" + e.ls() + "\\";
        }
        return ret;
    }

    public void add(Element element)
    {
        children.add(element);
    }

    public void remove(Element element)
    {
        children.remove(element);
    }
}
