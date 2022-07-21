public class Mari {
    public static void main(String[] args) {
        Folder root = new Folder("root");
        Folder subfolder = new Folder("users");
        Element a = new File("a.txt");
        root.add(a);
        root.add(subfolder);
        System.out.println(root.ls());
    }
}
