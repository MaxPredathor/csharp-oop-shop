namespace csharp_oop_shop
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto prodotto1 = new Prodotto("Pane", "Molto croccante", 12.95, 0.22);
            Console.WriteLine($"Codice: {prodotto1.Codice}, Nome: {prodotto1.Nome}, Descrizione: {prodotto1.Descrizione}, Prezzo: {prodotto1.Prezzo}, IVA: {prodotto1.Iva}");
            double prezzoNormale = prodotto1.PrezzoBase();
            Console.WriteLine($"Prezzo base: {prezzoNormale}");
            double prezzoConIva = prodotto1.PrezzoComprensivoDiIva();
            Console.WriteLine($"Prezzo con IVA: {prezzoConIva}");
            Console.WriteLine(prodotto1.PrezzoConCodice());
            Console.WriteLine(prodotto1.CodiceConPad());
            Prodotto[] nuoviProdotti =
            {
                new Prodotto ("Latte", "Fresco e genuino", 15.50, 0.4),
                new Prodotto ("Pasta", "Grano saraceno", 10.00, 0.4),
                new Prodotto ("Coca-Cola", "Bevanda da 1L", 8.50, 0.9),
                new Prodotto ("Batterie", "AAA", 20.50, 0.22),
                new Prodotto ("Spremiagrumi", "Spreme gli agrumi", 60.75, 0.22),
            };
            int counter = 1;
            foreach (Prodotto prodotto in nuoviProdotti)
            {

                Console.WriteLine($"\n\nProdotto n {counter}/{nuoviProdotti.Length}");
                Console.WriteLine($"\nCodice: {prodotto.Codice}, \nNome: {prodotto.Nome}, \nDescrizione: {prodotto.Descrizione}, \nPrezzo: {prodotto.Prezzo} Euro, \nIVA: {prodotto.Iva}");
                counter++;
            }
        }
    }
}
