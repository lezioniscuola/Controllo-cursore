using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Controllo_cursore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stampa asterisco giallo su sfondo rosso in posizione 60,20
            Console.SetCursorPosition(60, 20);//setta la posizione del cursore
            Console.BackgroundColor = ConsoleColor.Red;//setta il colore di sfondo
            Console.ForegroundColor=ConsoleColor.Yellow;//setta il colore del carattere
            Console.WriteLine("*");
            Console.BackgroundColor = ConsoleColor.Black;
            //stampa una diagonale di asterischi di vari colori
            for (int i = 30; i>1; i--)
            {
                Console.SetCursorPosition(i+10, i);
                Console.ForegroundColor = (ConsoleColor)(i%15);//i codici dei colori vanno da 0 a 15
                Console.WriteLine("*");
                Thread.Sleep(200);
            }
            //simulazione movimenti simultanei
            for (int i = 0; i<25 ; i++)
            {
                //movimento verso destra-sinistra
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(i,12);
                    Console.WriteLine(" *");
                //movimento sinistra-destra
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(80-i, 11);
                    Console.WriteLine("* ");
                //movimento alto-basso
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    //cancella la posizione precedente
                    Console.SetCursorPosition(40,i);
                    Console.WriteLine(" ");
                    //stampa carattere 
                    Console.SetCursorPosition(40, i+1);
                    Console.WriteLine("*");
                //movimento basso alto
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    //cancella la posizione precedente
                    Console.SetCursorPosition(41, 25-i);
                    Console.WriteLine(" ");
                    //stampa carattere 
                    Console.SetCursorPosition(41, 24-i);
                    Console.WriteLine("*");
                //ritardo di 100 millisecondi
                    Thread.Sleep(100);
            }
            //riposiziona il cursore in alto e stampa "terminato"
            Console.SetCursorPosition(40, 26);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Terminato");
        }
    }
}
