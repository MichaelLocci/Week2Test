using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week2.Test.Goods
{
    public class SpiritDrinkGood : Good
    {
        public Tipo Tipo { get; set; }
        public int GradazioneAlcolica { get; set; }

        public SpiritDrinkGood(Tipo tipo, int gradazione, int code, string descr, double prezzo, int quantgiac) : base(code, descr, prezzo, quantgiac)
        {
            Tipo = tipo;
            GradazioneAlcolica = gradazione;
            CodiceMerce = code;
            Descrizione = descr;
            Prezzo = prezzo;
            QuantitaGiacenza = quantgiac;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Tipo: {Tipo}\n" +
                $"Gradazione Alcolica: {GradazioneAlcolica}";
        }
    }
}
