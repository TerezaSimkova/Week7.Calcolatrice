using System;
using Week7.Calcolatrice.Core;
using Xunit;

namespace Week7.Calcolatrice.Test
{
    public class CalcolateTest
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Operazioni operazioni = new Operazioni();

            //ACT:
            double risultato = operazioni.RisolviOperazioniCalcolatriceSomma(1, 3);

            //Assert: verifica del risultato
            Assert.True(risultato == 4);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            Operazioni operazioni = new Operazioni();

            //ACT:
            double risultato = operazioni.RisolviOperazioniCalcolatriceSottrazione(6, 3);

            //Assert: verifica del risultato
            Assert.True(risultato == 3);

        }

        [Fact]
        public void Test3()
        {
            //Arrange
            Operazioni operazioni = new Operazioni();

            //ACT:
            double? risultato = operazioni.RisolviOperazioniCalcolatriceDivisione(6, 3);

            //Assert: verifica del risultato
            Assert.True(risultato == 2);
            // Assert.Null(risultato == null);
        }

        [Fact]
        public void Test4()
        {
            //Arrange
            Operazioni operazioni = new Operazioni();

            //ACT:
            double risultato = operazioni.RisolviOperazioniCalcolatriceMoltiplicazione(5, 2);

            //Assert: verifica del risultato
            Assert.True(risultato == 10);

        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB()
        {
            //ARRANGE: predisposizione del test
            Operazioni operazione = new Operazioni(); //modificate il nome della classe in base a quella che avete voi nel Core
                                                      //ACT: chiamata alla funzionalità da testare
            bool risultato = operazione.VerificaSeAMaggioreDiB(3, 1);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB2()
        {
            //ARRANGE: predisposizione del test
            Operazioni operazione = new Operazioni(); //modificate il nome della classe in base a quella che avete voi nel Core
                                                      //ACT: chiamata alla funzionalità da testare
            bool risultato = operazione.VerificaSeAMaggioreDiB2(3.2, 3.2);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }
    }
}
