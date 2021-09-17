using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week2.Test.Goods
{
    public class PerishableGood : Good
    {
        public DateTime DataScadenza { get; set; }
        public Modalita ModalitaConservazione { get; set; }

        public PerishableGood(DateTime datasc, Modalita mode, int code, string descr, double prezzo, int quantgiac) : base(code, descr, prezzo, quantgiac)
        {
            DataScadenza = datasc;
            ModalitaConservazione = mode;
            CodiceMerce = code;
            Descrizione = descr;
            Prezzo = prezzo;
            QuantitaGiacenza = quantgiac;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Data Scadenza: {DataScadenza}\n" +
                $"Modalita di Conservazione: {ModalitaConservazione}";
        }
    }
}
