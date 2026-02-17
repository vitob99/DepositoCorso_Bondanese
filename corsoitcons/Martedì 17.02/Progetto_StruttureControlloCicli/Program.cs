using System;

class Program{
    const int NUMERO_SEGRETO = 74;
    public static void Main(string[] args){
        //CICLO WHILE
        bool continua = true;
        while (continua){ //finché “continua” rimane true il codice viene ripetuto
            Console.WriteLine("Ciclo in esecuzione");
            continua = bool.Parse(Console.ReadLine());
        }

        int continua2 = 0;
        while(continua2 < 10){
            Console.WriteLine("Ciclo in esecuzione");
            continua2 += 1;
        }


        /*
        1. Scrivi un programma che continui a chiedere all’utente di inserire numeri interi positivi.
           Il programma termina quando l’utente inserisce un numero negativo e stampa la
           somma totale dei numeri inseriti (senza contare il numero negativo).
        */
        int somma = 0;
        int numero = 1;
        while (numero > 0){
            Console.Write("Inserisci un numero positivo: ");
            numero = int.Parse(Console.ReadLine());
            if(numero > 0){
                somma += numero;
            }
        }
        Console.WriteLine($"La somma e' {somma}");


        /*
        2. Scrivi un programma che definisca un numero segreto come costante. L'utente dovrà
        indovinare questo numero continuando a fare tentativi finché non lo indovina
        correttamente. Il programma risponde ogni volta indicando se il numero inserito è
        maggiore o minore rispetto al numero segreto.
        */
        bool trovato = false;
        while(trovato == false){
            Console.Write("Inserisci un numero: ");
            int numero_inserito = int.Parse(Console.ReadLine());
            if(numero_inserito > NUMERO_SEGRETO){
                Console.WriteLine($"Sbagliato! Il numero {numero_inserito} e' piu' grande del numero segreto!");
            }
            else if(numero_inserito < NUMERO_SEGRETO){
                Console.WriteLine($"Sbagliato! Il numero {numero_inserito} e' piu' piccolo del numero segreto!");
            }
            else if(numero_inserito == NUMERO_SEGRETO)
            {
                Console.WriteLine($"Corretto, {numero_inserito} e' il numero segreto!");
                trovato = true;
            }
        }





    }
}