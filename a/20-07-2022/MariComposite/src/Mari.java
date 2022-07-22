public class Mari {
    public static void main(String[] args) {
        Folder root = new Folder("user");
        Folder subfolder = new Folder("nome");
        Element a = new File("a.txt");
        root.add(a);
        root.add(subfolder);
        subfolder.add(new File("sium.png"));
        subfolder.add(new File("Dybala_alla_roma.jpeg"));
        root.add(new File("ahahahahahaha.c"));
        Folder docs = new Folder("Documents");
        Folder ab = new Folder("ab");
        subfolder.add(docs);
        docs.add(ab);
        ab.add(new File("gesu.png"));
        root.add(new Folder("empty"));
        //System.out.println(root.tree(""));
        root.print("");
        System.out.println("------");
        subfolder.print("");
    }
}
