package Java;
import java.util.Scanner;

public class programm {
    public static void main(String[] args) {
        // Scanner iScanner = new Scanner(System.in);
        // System.out.printf("name: ");
        // String name = iScanner.nextLine();
        // System.out.printf("Привет , %s!", name);
        // iScanner.close();
        // String s = "qwe";
        // int a = 123;
        // String q = s + a;
        // System.out.println(q);
        lib.sayHi();
        int mounth = Integer.parseInt(System.console().readLine());
        switch (mounth) {
            case 1:
                lib.sayHi();
                break;
            case 2:
                
                break;
        
            default:
                break;
        }
    }

}
