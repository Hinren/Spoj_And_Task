/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zad_3;

import java.io.Console;
import java.util.Scanner;
/**
 *
 * @author Patryk Wiśniewski
 */
public class Zad_3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        long Liczba;
        long Suma_cyfr = 0;
        Scanner in = new Scanner(System.in);
        
        System.out.println("Podaj liczbe");
        Liczba = in.nextInt();
        
        while (Liczba != 0) {
            Suma_cyfr += Liczba%10;
            Liczba /= 10;
        }
        while(Suma_cyfr > 9){
            Suma_cyfr -= 9;
        }
        if (Suma_cyfr % 3 == 0 || Suma_cyfr == 0) {
            System.out.println("True");
        }
        else{
            System.out.println("False");
        }
    
        
    }
    
}
