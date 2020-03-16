using System;

namespace TheSuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            monitor lgMonitor = new monitor("1200x600", true, 32);
            printer hpPrinter = new printer("HP", "MP102", 50);

            vga nvdiavga = new vga("Nvdia", 2054, 2054);
            Ram samsungRam = new Ram("DDR4", 5000, 8000);
            Processor intelProcessor = new Processor();
            intelProcessor.setCache(254);
            intelProcessor.setCore(8);
            intelProcessor.setSeries("CORE i7 8th Gen");

            computer computer = new computer.Builder(samsungRam, nvdiavga, intelProcessor)
                .withMonitor(lgMonitor)
                .withPrinter(hpPrinter)
                .builder();
            Console.WriteLine(computer.ToString());
        }
    }
}
      