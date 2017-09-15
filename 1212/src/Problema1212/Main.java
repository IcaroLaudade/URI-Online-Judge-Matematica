/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Problema1212;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        while (true) {
            int a = s.nextInt();
            int b = s.nextInt();
            int numeroSubiu = 0;
            int cont = 0;
            if (a == 0 && b == 0) {
                break;
            }
            while (a != 0 || b != 0) {
                int restoa = a % 10;
                int restob = b % 10;
                if (restoa + restob + numeroSubiu >= 10) {
                    cont++;
                    numeroSubiu = 1;
                } else {
                    numeroSubiu = 0;
                }
                a = a / 10;
                b = b / 10;
            }
            if (cont == 0) {
                System.out.println("No carry operation.");
            } else if (cont == 1) {
                System.out.println("1 carry operation.");
            } else {
                System.out.println(cont + " carry operations.");
            }
        }
    }

}
