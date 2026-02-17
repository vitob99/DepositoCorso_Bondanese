using System;

class Program{
    const int MAGGIORE_ETA = 18;
    const float PREZZO_FISSO = 100;
    const float PERCENTUALE_SCONTO = 10;

    public static void Main(string[] args){
        int a = 15;
        int b = 10;
        /* if (condizione == true){
            // esegui codice all'interno delle graffe
        }*/
        if(a > b){ // (a<b) da come risultato True
            Console.WriteLine($"{a} è maggiore di {b}");
            /* il blocco di codice all'interno delle graffe verrà eseguito solo
            se la condizione è vera, altrimenti verrà
            saltato e ignorato durante l’esecuzione */
        }

        /*
        1.Scrivere un programma che chieda all'utente la sua età e stampi a schermo se è maggiorenne o minorenne
            a.Richieste tecniche:
                i.Input con Console.ReadLine()
                ii.Casting implicito ed esplicito
                iii.Uso di variabili e costanti
        */
        Console.Write("Inserisci la tua eta': ");
        int etaUtente = int.Parse(Console.ReadLine());
        if(etaUtente >= MAGGIORE_ETA){
            Console.WriteLine("L'utente e' maggiorenne");
        }
        if(etaUtente < MAGGIORE_ETA){
            Console.WriteLine("L'utente e' minorenne");
        }

        /*
        2.Scrivere un programma che richiede all'utente il prezzo di un prodotto 
        e applica uno sconto del 10% se il prezzo supera 100€. 
        Stampare il prezzo finale.
                a.Richieste tecniche:
                    i.Utilizzo di input e conversioni esplicite
                    ii.Uso degli operatori aritmetici
                    iii.Stampare con formattazione della stringa
        */

        Console.Write("Prezzo del prodotto: ");
        float prezzo = float.Parse(Console.ReadLine());

        if(prezzo > PREZZO_FISSO){
            float prezzo_scontato = prezzo - prezzo * PERCENTUALE_SCONTO / 100;
            Console.WriteLine($"Prezzo scontato del 10%: {prezzo_scontato}");
        }

        /*
        3.Scrivere un programma che chiede tre numeri interi all'utente. 
        Se la media aritmetica dei tre numeri è maggiore o uguale a 60, stampare "Hai superato la prova!"
        , altrimenti stampare "Prova fallita." Stampare anche il valore esatto della media.
                a.Richieste tecniche:
                    i.Casting tra tipi (int e double)
                    ii.Utilizzo di operatori aritmetici e di confronto
                    iii.Stampa formattata di valori numerici
        */

        Console.Write("Inserisci il primo numero intero : ");
        float n1 = float.Parse(Console.ReadLine());
        Console.Write("Inserisci il secondo numero intero : ");
        float n2 = float.Parse(Console.ReadLine());
        Console.Write("Inserisci il terzo numero intero : ");
        float n3 = float.Parse(Console.ReadLine());

        float media = (n1 + n2 + n3) / 3;

        if(media >= 60){
            Console.WriteLine($"La media dei numeri inseriti è {media}: Hai superato la prova!");
        }             
        if(media < 60){
            Console.WriteLine($"La media dei numeri inseriti è {media}: Prova fallita.");
        }

        // EXTRA
        if(n1 == 5 || n2 == 10){
            Console.WriteLine("Il primo numero inserito e' uguale a 10 o il secondo e' uguale a 10");
        }
        if(n1 == 10 && n3 == 50){
            Console.WriteLine("Il primo numero inserito e' uguale a 10 e il terzo e' uguale a 50");
        }
        if(!(n1 == n2)){
            Console.WriteLine("Il primo numero inserito e il secondo sono diversi!");
        }


    }
}