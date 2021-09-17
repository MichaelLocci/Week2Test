using System;

namespace AcademyG.Week2.Test
{
    public class Good
    {

        public int CodiceMerce { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        public int QuantitaGiacenza { get; set; }

        public Good(int codiceMerce, string descrizione, double prezzo, int quantitaGiacenza)
        {
            CodiceMerce = codiceMerce;
            Descrizione = descrizione;
            Prezzo = prezzo;
            DataUltimaOperazione = DateTime.Now;
            QuantitaGiacenza = quantitaGiacenza;
        }

        public override string ToString()
        {
            return $"CodiceMerce: {CodiceMerce}\n" +
                $"Descrizione: {Descrizione}\n" +
                $"Prezzo: {Prezzo}\n" +
                $"DataUltimaOperazione: {DataUltimaOperazione}\n" +
                $"QuantitàMerciGiacenza: {QuantitaGiacenza}";
        }
    }
}