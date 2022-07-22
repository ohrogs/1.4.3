import java.util.LinkedList;

public class Folder implements Element{ //COMPOSITE

    private String name;
    private LinkedList<Element> children;

    public Folder(String name)
    {
        this.name = name;
        children = new LinkedList<>();
    }

    /*@Override
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
    }*/

    /*@Override
    public String ls()//Stampa piu ordinata ma errata
    {
        String ret = "\\"+ name +"\n";
        //tirare qualcosa fuori dal cappello
        for (Element e : children) {
            ret += e.ls();
        }
        return ret;
    }*/

    public String ls()//stampa quasi a posto
    {
        return "";
    }

    public String tree(String tabs)//stampa quasi a posto
    {
        return "";
        /*
        if vuota
            return nome
        if leaf stampa e basta
        if folder spacchetta tutto*/
    }

    @Override
    public void print(String prev) {
        if(children.size() == 0)
        {
            System.out.println(prev+"\\"+name);
        }
        for (Element e : children)
        {
            e.print(prev+"\\"+name);
        }
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
