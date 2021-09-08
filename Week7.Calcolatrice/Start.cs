using System;
using Week7.Calcolatrice.Core;

namespace Week7.Calcolatrice
{
    internal class Start
    {
        internal static void Menu()
        {
            int scelta;
            bool continua = true;
            Console.WriteLine("***Calcolatrice***\n");

            while (continua)
            {
                Console.WriteLine("1. Somma:");
                Console.WriteLine("2. Sottrazione:");
                Console.WriteLine("3. Divisione:");
                Console.WriteLine("4. Moltiplicazione:");
                Console.WriteLine("5. Per verificare se il primo numero e maggiore del secondo numero:");
                Console.WriteLine("\n0. Per uscire.");
                do
                {
                    Console.WriteLine("\nScegli operazione che voresti fare:");

                } while (!int.TryParse(Console.ReadLine(), out scelta));

                switch (scelta)
                {
                    case 1:
                        Somma();
                        break;
                    case 2:
                        Sottrazione();
                        break;
                    case 3:
                        Divisione();
                        break;
                    case 4:
                        Moltiplicazione();
                        break;
                    case 5:
                        Maggiore();
                        break;
                    case 0:
                        continua = false;
                        break;
                }
            }
        }

        private static void Maggiore()
        {
            Operazioni operazione = new Operazioni();

            int num1;
            int num2;
            bool result=true;

            do
            {
                Console.WriteLine("Inserisci il primo numero:");

            } while (!int.TryParse(Console.ReadLine(), out num1));

            do
            {
                Console.WriteLine("Inserisci il secondo numero:\n");

            } while (!int.TryParse(Console.ReadLine(), out num2));

            Console.WriteLine($"Operazione da svolgere: {num1} > {num2}\n");
            if (result == true)
            {
                result = operazione.VerificaSeAMaggioreDiB(num1, num2);
                Console.WriteLine($"Risultato: {result}");
            }
            if (result == false)
            {
                Console.WriteLine("Numeri risultano uguali!\n");
            }
        }

        private static void Moltiplicazione()
        {
            Operazioni operazione = new Operazioni();

            double num1;
            double num2;
            double result;

            do
            {
                Console.WriteLine("Inserisci il primo numero:");

            } while (!double.TryParse(Console.ReadLine(), out num1));

            do
            {
                Console.WriteLine("Inserisci il secondo numero:\n");

            } while (!double.TryParse(Console.ReadLine(), out num2));

            Console.WriteLine($"Operazione da svolgere: {num1} * {num2}\n");

            result = operazione.RisolviOperazioniCalcolatriceMoltiplicazione(num1, num2);
            Console.WriteLine($"Risultato: {result}");
        }

        private static void Sottrazione()
        {
            double num1;
            double num2;
            double result;

            do
            {
                Console.WriteLine("Inserisci il primo numero:");

            } while (!double.TryParse(Console.ReadLine(), out num1));

            do
            {
                Console.WriteLine("Inserisci il secondo numero:\n");

            } while (!double.TryParse(Console.ReadLine(), out num2));

            Console.WriteLine($"Operazione da svolgere: {num1} - {num2}\n");

            Operazioni operazione = new Operazioni();
            result = operazione.RisolviOperazioniCalcolatriceSottrazione(num1, num2);

            Console.WriteLine($"Risultato: {result}");
        }

        private static void Divisione()
        {
            double num1;
            double num2;
            double? result;

            do
            {
                Console.WriteLine("Inserisci il primo numero:");

            } while (!double.TryParse(Console.ReadLine(), out num1));

            do
            {
                Console.WriteLine("Inserisci il secondo numero:\n");

            } while (!double.TryParse(Console.ReadLine(), out num2));

            Console.WriteLine($"Operazione da svolgere: {num1} / {num2}\n");

            Operazioni operazione = new Operazioni();

            result = operazione.RisolviOperazioniCalcolatriceDivisione(num1, num2);

            if (result == null)
            {
                Console.WriteLine($"Impossibile di dividere per: {num2}!");
            }
            else
            {
                Console.WriteLine($"Risultato: {result}");
            }
        }

        private static void Somma()
        {
            double num1;
            double num2;
            double result;

            do
            {
                Console.WriteLine("Inserisci il primo numero:");

            } while (!double.TryParse(Console.ReadLine(), out num1));

            do
            {
                Console.WriteLine("Inserisci il secondo numero:\n");

            } while (!double.TryParse(Console.ReadLine(), out num2));

            Console.WriteLine($"Operazione da svolgere: {num1} + {num2}\n");

            Operazioni operazione = new Operazioni();
            result = operazione.RisolviOperazioniCalcolatriceSomma(num1, num2);

            Console.WriteLine($"Risultato: {result}");
        }

    }
}