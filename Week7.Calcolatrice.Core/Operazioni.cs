using System;

namespace Week7.Calcolatrice.Core
{
    public class Operazioni
    {

        public bool VerificaSeAMaggioreDiB(int a, int b)
        {
            bool maggiore = true;
            if (a > b)
            {
                return maggiore;
            }
            if (a < b)
            {
                return false;
            }
            return maggiore;
        }

        public double RisolviOperazioniCalcolatriceSomma(double a, double b)
        {
            double somma = a + b;
            return somma;
        }

        public double? RisolviOperazioniCalcolatriceDivisione(double a, double b)
        {
            if (b == 0)
            {
                return null;
            }
            else
            {
                double divisione = a / b;
                return divisione;
            }
            //double? divisione = a / b;
            //return divisione;
           
        }

        public double RisolviOperazioniCalcolatriceSottrazione(double a, double b)
        {
            double sottrazione = a - b;
            return sottrazione;

        }

        public double RisolviOperazioniCalcolatriceMoltiplicazione(double a, double b)
        {
            double moltiplicazione = a * b;
            return moltiplicazione;
        }

        public bool VerificaSeAMaggioreDiB2(double a, double b)
        {
            bool maggiore = true;
            if (a >= b)
            {
                return maggiore;
            }
            if (a <= b)
            {
                return false;
            }
            return maggiore;
        }
    }
}
