using AcademyG.Week2.Test.Goods;
using System;

namespace AcademyG.Week2.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse<Good> goods = new(Guid.NewGuid(), "via campello");

            while (true)
            {
                Console.WriteLine("scegli cosa vuoi fare:\n" +
                "a - aggiungi merce\n" +
                "b - rimuovi merce\n" +
                "c - stampa resoconto merce ");
                string menu = Console.ReadLine();

                if (menu == "a")
                {
                    Console.WriteLine("Scegli la merce da inserire:\n" +
                        "1 - ElectronicGood\n" +
                        "2 - SpiritDrinkGood\n" +
                        "3 - PerishableGood\n" +
                        "4 - premi q per uscire");
                    string comando = Console.ReadLine();

                    switch (comando)
                    {
                        case "1":
                            Console.WriteLine("inserisci il produttore");
                            string produttore = Console.ReadLine();
                            Console.WriteLine("inserisci il codice");
                            int.TryParse(Console.ReadLine(), out int codiceprod);
                            Console.WriteLine("inserisci la descrizione");
                            string descrizioneE = Console.ReadLine();
                            Console.WriteLine("inserisci il prezzo");
                            double.TryParse(Console.ReadLine(), out double prezzoE);
                            Console.WriteLine("inserisci la quantita");
                            int.TryParse(Console.ReadLine(), out int quantitaE);

                            ElectronicGood electronicGood = new(produttore, codiceprod, descrizioneE, prezzoE, quantitaE);
                            goods += (electronicGood);
                            break;

                        case "2":
                            Console.WriteLine("inserisci il tipo: FREEZER, FRIDGE, SHELF");
                            Enum.TryParse(Console.ReadLine(), out Tipo tipo);
                            Console.WriteLine("inserisci la gradazione");
                            int.TryParse(Console.ReadLine(), out int gradazione);
                            Console.WriteLine("inserisci il codice");
                            int.TryParse(Console.ReadLine(), out int codice);
                            Console.WriteLine("inserisci la descrizione");
                            string descrizioneS = Console.ReadLine();
                            Console.WriteLine("inserisci il prezzo");
                            double.TryParse(Console.ReadLine(), out double prezzoS);
                            Console.WriteLine("inserisci la quantita");
                            int.TryParse(Console.ReadLine(), out int quantitaS);

                            SpiritDrinkGood drinkGood = new(tipo, gradazione, codice, descrizioneS, prezzoS, quantitaS);
                            goods += (drinkGood);
                            break;

                        case "3":
                            Console.WriteLine("inserisci la data di scadenza ");
                            DateTime.TryParse(Console.ReadLine(), out DateTime data);
                            Console.WriteLine("inserisci modalità  di conservazione: WHISKY, WODKA, GIN, OTHER");
                            Enum.TryParse(Console.ReadLine(), out Modalita modalita);
                            Console.WriteLine("inserisci il codice");
                            int.TryParse(Console.ReadLine(), out int codiceP);
                            Console.WriteLine("inserisci la descrizione");
                            string descrizioneP = Console.ReadLine();
                            Console.WriteLine("inserisci il prezzo");
                            double.TryParse(Console.ReadLine(), out double prezzoP);
                            Console.WriteLine("inserisci la quantita");
                            int.TryParse(Console.ReadLine(), out int quantitaP);

                            PerishableGood perishableGood = new(data, modalita, codiceP, descrizioneP, prezzoP, quantitaP);
                            goods += (perishableGood);
                            break;

                        case "4":
                            break;

                    }

                }
                else if(menu == "b")
                {
                    
                }
                else if(menu == "c")
                {
                    Console.WriteLine(goods.StockList());
                }
            }

        }
    }
}
