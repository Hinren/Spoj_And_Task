/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zad_01;

import java.util.Random;

/**
 *
 * @author hirek
 */
public class Zad_01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Random r = new Random();
       int a = r.nextInt(150) -1;
       int b = a;
       int pierwsza = a;
       int min = -50, max = -50;
       int srednia = 0; 
       int s = 0;
       while(a != 0){
           if (b < a ) {
               max = a;
           }
           if (b > a) {
               min = a;
           }
           if (a > 0) {
               if (a % 2 == 0) {
                   srednia += a; 
                   s++;
               }
           }
           b = a;
           a = r.nextInt(150) -1;
       }
       
        if (pierwsza < 0) {
       pierwsza = pierwsza * (-1);  
       System.out.print("Ciąg Fibonnaciego:");
       }     
        int n3 = 0;
        int n1=0,n2=1;  
        int m = 1;
                while(n3 < pierwsza){ 
                     n3=n1+n2;    
                     System.out.print("Ciąg "+ m + " wynosi: " + n3 + "\n"); 
                     m++;
                     n1=n2;    
                     n2=n3;            
        }
       
       
       int srednia_k = srednia/s;
       System.out.print("Max to: "+ max + "\n" + "Minimum to: " + min + "\n"
       + "Srednia z kolei liczy parzystych wiekszych od zera to: " + srednia_k + "\n");
        // System.out.print("max wynosi: %max, natomiast min: %min. "
        //         + "srednia z kolei %srednia_k", max, min, srednia_k );
    }
    

}
