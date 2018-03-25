/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

import java.util.Random;

/**
 *
 * @author hirek
 */
public class JavaApplication1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Random generator = new Random();
       double losowa;
       int losowa2 = 0;
       int licznik = 1;
       int licznik_dodatnie = 0;
       double suma_dodatnich = 0;
       double suma_losowych1=0;
       int ile_liczb = 0;
       double suma = 0;
       double max_losowa;
       double srednia_arytmetyczna = 0;
       double srednia_arytmetyczna_1 = 0;
       losowa = (generator.nextInt(20) - 10 ) ;
       max_losowa = losowa;
       while(losowa != 0.0){
           if (max_losowa < losowa) {
               max_losowa = losowa;
           }
           suma_losowych1 += losowa;
           // Warunek czy liczba jest dodatnia i czy jest podzielna przez 3
           //jesli tak to zliczaj średnią arytmetyczną tych liczb
           if (losowa > 0.0 && losowa % 3 == 0) {
               licznik_dodatnie++;
               suma_dodatnich += losowa;
           }
           //Suma co drugiej wylosowanej liczby
           if (licznik % 2 == 0) {
                   suma += losowa;
           }
           System.out.println(losowa);
           losowa = (generator.nextInt(20) - 10)  ;
           ile_liczb++;
           licznik++;
           
       }
       // srednia arytmetyczna wszystkich wylosowanych liczb
       srednia_arytmetyczna = suma_losowych1 / ile_liczb;
       srednia_arytmetyczna_1 = suma_dodatnich / licznik_dodatnie;
       System.out.println("Średnia arytmetyczna liczb dodatnich "
               + "pordzielnych przez 3 wynosi :" + srednia_arytmetyczna_1);
       System.out.println("Suma co drugiej liczby wynosi :" + suma);
        int ile_wiekszych = 0;
        int suma_2 = 0;
        int arytmetyczna_numer_2 = 0;
        double roznica = 0;
        for (int i = 0; i < ile_liczb; i++) {
            losowa2 = generator.nextInt(20) - 10;
            suma_2 += losowa2;
            if (max_losowa < losowa2) {
                ile_wiekszych++;
            }
        }
        arytmetyczna_numer_2 = losowa2 / ile_liczb;
        if (srednia_arytmetyczna > arytmetyczna_numer_2 ) {
            roznica = srednia_arytmetyczna - arytmetyczna_numer_2;
            System.out.println("Różnica średn arytmetycznych to " + roznica
            + " Srednia z pierwszego zestawu jest wieksza");
        }
        else{
            roznica =  arytmetyczna_numer_2 - srednia_arytmetyczna;
            System.out.println("Różnica średn arytmetycznych to " + roznica
            + " Srednia z drugiego zestawu jest wieksza");
        }
    }
    
}
