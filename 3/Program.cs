namespace Commuting
{
    internal class Program
    {
        static List<Prijevoz> prijevozi = new List<Prijevoz>();

        static void Main(string[] args)
        {
            prijevozi.Add(new Prijevoz("pjeske", 0, 50, 0, 0));
            prijevozi.Add(new Prijevoz("bicikl", 0, 20, 150, 20));
            prijevozi.Add(new Prijevoz("automobil", 1.25, 10, 25000, 400));
            prijevozi.Add(new Prijevoz("elektricni romobil", 0.85, 12, 0, 1*12));
            prijevozi.Add(new Prijevoz("javni prijevoz", 2.5, 11, 0, 0));
            prijevozi.Add(new Prijevoz("taksi", 5, 8, 0, 0));

            prvi();

            drugi();

            treci();

            Console.WriteLine("\n\nPritisni enter za izlaz...");
            Console.ReadLine();
        }

        static void prvi()
        {
            int brojDana = ValidacijaUnosa();

            double optPrijevoz = double.MaxValue;
            Prijevoz najboljiPrijevoz = new Prijevoz("", 0, 0, 0, 0);

            foreach(Prijevoz prijevoz in prijevozi)
            {
                double vrijeme = prijevoz.Vrijeme * brojDana;
                double cijena = prijevoz.Cijena * brojDana;
                if(optPrijevoz > cijena + vrijeme)
                {
                    optPrijevoz = cijena + vrijeme;
                    najboljiPrijevoz = prijevoz;
                }

                Console.WriteLine($"Za prijevoz \u001b[1m{prijevoz.Naziv}\u001b[0m" +
                    $" koštat će \u001b[1m{cijena} eura\u001b[0m i trajat ce \u001b[1m{vrijeme} minuta\u001b[0m.");
            }

            Console.WriteLine($"\nNajefikasniji prijevoz je \u001b[1m{najboljiPrijevoz.Naziv}\u001b[0m");
        }

        private static int ValidacijaUnosa()
        {
            Console.WriteLine("Hej Marija unesi broj dana koji ćeš ići na posao:");
            var brojDanaTekst = Console.ReadLine();

            if (brojDanaTekst == "")
            {
                Console.WriteLine("Marija molim te ubuduće upiši broj dana!");
                Environment.Exit(0);
            }
            try
            {
                return int.Parse(brojDanaTekst);
            }
            catch
            {
                Console.WriteLine("Marija molim te ubuduće upiši ispravan broj dana!");
                Environment.Exit(0);
            }
            return 0;
        }

        static void drugi()
        {
            Console.WriteLine("\n\nDa bi dobili točnije podatke trebamo uračunati i" +
                " trošak kupnje i održavanja");
            Console.WriteLine("S njima za prvu godinu dana će vrijeme i cijena biti:\n");
            int brojDana = 220;
            double optPrijevoz = double.MaxValue;
            Prijevoz najboljiPrijevoz = new Prijevoz("", 0, 0, 0, 0);

            foreach (Prijevoz prijevoz in prijevozi)
            {
                double vrijeme = prijevoz.Vrijeme * brojDana;
                double cijena = prijevoz.Cijena * brojDana + prijevoz.PocetnaCijena + prijevoz.Odrzavanje;
                if (optPrijevoz > cijena + vrijeme)
                {
                    optPrijevoz = cijena + vrijeme;
                    najboljiPrijevoz = prijevoz;
                }
                Console.WriteLine($"Za prijevoz \u001b[1m{prijevoz.Naziv}\u001b[0m" +
                    $" koštat će \u001b[1m{cijena} eura\u001b[0m i trajat ce \u001b[1m{vrijeme} minuta\u001b[0m.");
            }

            Console.WriteLine($"\nNajefikasniji prijevoz je \u001b[1m{najboljiPrijevoz.Naziv}\u001b[0m");
        }

        static void treci()
        {
            Prijevoz elAuto = new Prijevoz("elektricni automobil", 0, 12, 30000, 100);
            Prijevoz benzAuto = prijevozi[2];

            double elAutoCijena = elAuto.PocetnaCijena;
            double benzAutoCijena = benzAuto.PocetnaCijena;

            for (int i = 1; i < 100; i++)
            {
                elAutoCijena += elAuto.Cijena * 220 + elAuto.Odrzavanje;
                benzAutoCijena += benzAuto.Cijena * 220 + benzAuto.Odrzavanje;

                if(elAutoCijena < benzAutoCijena)
                {
                    Console.WriteLine($"\n\nNakon {i} godina elektricni auto se isplati u usporedbi s benzinskim autom");
                    break;
                }
            }
        }
    }
}
