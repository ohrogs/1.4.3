import java.util.Scanner;

class main {
    public static void main(String[] args) {
        Scanner key = new Scanner(System.in);
        System.out.println("inserire lun");
        int lun = key.nextInt();
        System.out.println("inserire alt");
        int alt = key.nextInt();
        Rectangle x = new Rectangle(lun, alt);
        System.out.println(x.area());
        System.out.println(x.perimetro());
    }
}