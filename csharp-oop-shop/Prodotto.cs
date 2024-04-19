using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        public int Codice { get; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double Iva {  get; set; }

        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            Random random = new Random();
            Codice = random.Next(1, 1000000);

            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;
        }
        public double PrezzoBase()
        {
            return Prezzo;
        }

        public double PrezzoComprensivoDiIva()
        {
            return Prezzo * (1 + Iva);
        }

        public string PrezzoConCodice()
        {
            return Convert.ToString(this.Codice) + " " + this.Nome;
        }

        public string CodiceConPad()
        {
            if (Convert.ToString(this.Codice).Length >= 8)
            {
                return Convert.ToString(this.Codice);
            }
            else
            {
                int pad = 8 - Convert.ToString(this.Codice).Length;
                string codiceConPad = Convert.ToString(this.Codice);
                for (int i = 0; i < pad; i++)
                {
                    codiceConPad = "0" + codiceConPad;
                }
                return codiceConPad;
            }
        }
    }
}
