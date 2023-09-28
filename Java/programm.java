package Java;

import java.io.*;
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
        for (int i = 0; i < 10; i++) {
            if (i % 2 == 0)
                continue;
            System.out.println(i);
        }
        int j = 0;
        while (j < 10000) {
            j++;
        }
        switch (mounth) {
            case 1:
                lib.sayHi();
                break;
            case 2:

                break;

            default:
                break;
        }

        int[] arr = new int[] { 1, 2, 3, 4, 5, 77 };
        for (int item : arr) {
            System.out.println(item);
        }
        try (FileWriter fw = new FileWriter("c:\\Examples\\SharpExamples\\Java\\file.txt", false)) {

            fw.write("line 1");
            fw.append('\n');
            fw.append('2');
            fw.append('\n');
            fw.write("line 3");
            fw.flush();

        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }

        try (FileReader fr = new FileReader("c:\\Examples\\SharpExamples\\Java\\file.txt")) {
            int c;
            while ((c = fr.read()) != -1) {
                char ch = (char) c;
                if (ch == '\n') {
                    System.out.print(ch);
                } else {
                    System.out.print(ch);
                }
            }
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
        System.out.println();

        try (BufferedReader br = new BufferedReader(new FileReader("c:\\Examples\\SharpExamples\\Java\\file.txt"))) {
            String str;
            while ((str = br.readLine()) != null) {
                System.out.printf("== %s ==\n", str);
            }
            br.close();

        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }

}
