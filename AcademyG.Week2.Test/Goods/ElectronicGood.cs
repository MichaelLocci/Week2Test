using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week2.Test.Goods
{
    public class ElectronicGood : Good
    {

        public string Produttore { get; set; }

        public ElectronicGood(string prod, int code, string descr,double prezzo, int quantgiac) : base(code, descr, prezzo, quantgiac)
        {
            Produttore = prod;
            CodiceMerce = code;
            Descrizione = descr;
            Prezzo = prezzo;
            QuantitaGiacenza = quantgiac;             
            
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Produttore: {Produttore}";
        }
    }
}
