namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 244;
            double speed = 120;

            double chargingSpeed = 1.5 / 75;
            double chargingTime = chargingSpeed * 35;

            double delay = 20.0 / 60.0;

            double AudiTime = (distance / speed) + chargingTime;
            double AMGTime = (distance / speed) + delay;

            Console.WriteLine("Zadatak 1:");
            if(AudiTime < AMGTime)
            {
                Console.WriteLine("Nažalost Juraj je došao prije vas :(");
            }
            else
            {
                Console.WriteLine("Bravo došli ste prije Juraja :)");
            }
            Console.WriteLine($"Juraj je došao za {FormatTime(AudiTime)}, a vi za {FormatTime(AMGTime)}.");
            Console.WriteLine();


            double tank = 66;
            double kilometre = 169;

            double gasUsage = 10.4 / 100;
            double gasLeft = tank - (kilometre * gasUsage);

            Console.WriteLine("Zadatak 2:");
            Console.WriteLine($"Nakon {kilometre}km ostalo je {gasLeft} litara goriva.");
            Console.WriteLine();


            double batteryUsage = 20.3 / 100;
            double battery = batteryUsage * 486;
            double batteryLeft = battery * 0.9;
            gasLeft = tank;

            Console.WriteLine("Zadatak 3:");
            Console.WriteLine($"Početak");
            Console.WriteLine($"Audi ima {batteryLeft:F2} kWh baterije.");
            Console.WriteLine($"AMG ima {gasLeft:F2} L goriva");
            Console.WriteLine();

            for (int km = 1; km <= distance; km++)
            {
                batteryLeft -= batteryUsage;
                gasLeft -= gasUsage;

                if(km % 50 == 0)
                {
                    Console.WriteLine($"{km}km");
                    Console.WriteLine($"Audi ima {batteryLeft:F2} kWh baterije.");
                    Console.WriteLine($"AMG ima {gasLeft:F2} L goriva");
                    Console.WriteLine();
                }

                if(km == 130)
                {
                    batteryLeft += battery * 0.35;
                }
            }

            Console.WriteLine($"Kraj");
            Console.WriteLine($"Audi ima {batteryLeft:F2} kWh baterije.");
            Console.WriteLine($"AMG ima {gasLeft:F2} L goriva");
            Console.WriteLine();

            Console.WriteLine("Pritisnite enter za završetak programa!");
            Console.ReadLine();
        }

        static string FormatTime(double time)
        {
            int hours = (int)time;
            int minutes = (int)((time - hours) * 60);
            return $"{hours:D2}:{minutes:D2}";
        }
    }
}