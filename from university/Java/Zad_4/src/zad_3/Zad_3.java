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


    public static void main(String[] args) {
        int rok, rok2;
        int Ile_przestepnych = 0;
        int Ile_dni = 0;
        Scanner in = new Scanner(System.in);
        
        System.out.println("Podaj pierwszy rok do sprawdzenia.");
        rok = in.nextInt();
        
        System.out.println("Podaj drugi rok do sprawdzenia.");
        rok2 = in.nextInt();
        
        //zabezpieczenie jesli uzytkownik poda tak
        //choc nie wiem czy o to chodzilo 
        if (rok2 > rok) {
                    for (int i = rok; i < rok2; i++) {
                         if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0) {
                                Ile_przestepnych++;
                         }
                    }
         Ile_dni = (((rok2 - rok) - Ile_przestepnych + 1) * 365) + (Ile_przestepnych * 366);
         System.out.println("Ile dni: " + Ile_dni);
        }
        
        if(rok2 == rok){
            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0) {
                                Ile_przestepnych++;
                         }
            if (Ile_przestepnych == 1) {
                System.out.println("Ile dni: 366");
            }
            else{
                System.out.println("Ile dni: 365");
            }
        }

    }
    
}
