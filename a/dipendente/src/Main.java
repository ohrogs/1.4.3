import java.util.Scanner;
public class Main {

    private static int  DIM = 3;

    private static void instructions()
    {
        System.out.println("1 per stampare tutto di tutti");
        System.out.println("2 per stampare tutto di n in input");
        System.out.println("3 o altro per uscire");
    }
    private static void fill(dipendente[]lista) //what is static?
    {
        Scanner key = new Scanner(System.in);
        for(int i = 0; i < DIM; i++)
        {
            String mat;
            int pagab, pagas;
            System.out.println("Inserire Matricola");
            mat = key.nextLine();
            System.out.println("Inserire Paga base");
            pagab = key.nextInt();
            System.out.println("Inserire Paga straordinaria");
            pagas = key.nextInt();
            lista[i] = new dipendente(mat, pagab, pagas);
            key.nextLine();
        }
    }
    private static void stampatutto(dipendente[]lista)
    {
        for(int i = 0; i < DIM; i++)
        {
            lista[i].stampa();
        }
    }

    public static void main(String[] args)
    {
        Scanner key = new Scanner(System.in);
        dipendente [] lista = new dipendente[DIM];
        boolean check=true;
        fill(lista);
        do
        {
            instructions();
            System.out.println("Inserire la scelta");
            int k = key.nextInt();
            switch (k)
            {
                case 1:
                    stampatutto(lista);
                    break;
                case 2:
                    System.out.println("Inserire il numero");
                    int pos = key.nextInt();
                    if(pos >= DIM)
                        System.err.println("overflow");
                    else
                        lista[pos].stampa();
                    break;
                default:
                    check=false;
                    break;
            }
            //check=false;
        }while (check);
    }
}