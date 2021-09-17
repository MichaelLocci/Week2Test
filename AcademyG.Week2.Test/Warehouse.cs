using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week2.Test
{
    public class Warehouse<T> :  IEnumerable<T> where T : Good
    {

        #region PROPRIETA
        public Guid IDMagazzino { get; set; }
        public string Indirizzo { get; set; }
        public double ImportoTotaleMerciGiacenza { get; set; }
        public DateTime DataUltimaOperazione { get; set; }

        private List<T> listaMerciGiacenza;

        #endregion

        #region COSTRUTTORE

        
        public Warehouse(Guid iDMagazzino, string indirizzo)
        {
            IDMagazzino = iDMagazzino;
            Indirizzo = indirizzo;
            ImportoTotaleMerciGiacenza = 0;
            DataUltimaOperazione = DateTime.Now;
            listaMerciGiacenza = new List<T>();
        }
        #endregion


        #region OVERLOAD +/-

        public static Warehouse<T> operator +(Warehouse<T> t, T item)
        {
            t.listaMerciGiacenza.Add(item);
            t.ImportoTotaleMerciGiacenza += (item.Prezzo * item.QuantitaGiacenza);
            t.DataUltimaOperazione = DateTime.Now;
            return t;
        }

        public static Warehouse<T> operator -(Warehouse<T> t , T item)
        {
            if(t.listaMerciGiacenza.Contains(item))
            {
                t.listaMerciGiacenza.Remove(item);
                t.ImportoTotaleMerciGiacenza -= (item.Prezzo * item.QuantitaGiacenza);
                t.DataUltimaOperazione = DateTime.Now;
            }
            else
            {
                Console.WriteLine("bene non presente in magazzino");
            }
            return t;
        }

        #endregion

        #region METODI

        public string StockList()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--- WAREHOUSE DETAILS ---");
            sb.AppendLine($"[ID Magazzino: {IDMagazzino}]\n" +
                $"Via: {Indirizzo}\n" +
                $"Data Ultima Operazione: {DataUltimaOperazione}\n" +
                $"Importo Totale Merci in giacenza: {ImportoTotaleMerciGiacenza} euro\n");
            sb.AppendLine("|--- GOODS STATUS ---|");
            foreach (T item in listaMerciGiacenza)
                sb.AppendLine($"[{item.ToString()}]\n");
            sb.AppendLine("--------------------");

            return sb.ToString();

        }
        /*
        public void LoadFromFile(string fileName)
        {
            string path = @"C:\Users\michael.locci\Desktop\AcademyG\Week2Test\AcademyG.Week2.Test" +fileName;
            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        string[] good = line.Split(":");

                        switch (good[0])
                        {
                            case "ElectronicGood":
                                string[] electronic = good[1].Split(";");
                                T item = new Good();
                        }
                    }
                }

            }
            catch(IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }*/

        #endregion


        #region IENUMERABLE
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in listaMerciGiacenza)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
