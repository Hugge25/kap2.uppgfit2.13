using System;

namespace uppgfit_2._13
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Vad är Eriks lön?");
            string Erik = Console.ReadLine();
            Console.WriteLine("Vad är Marias lön?");
            string Maria = Console.ReadLine();
            Console.WriteLine("Vad är Jimmies lön?");
            string Jimmie = Console.ReadLine();

            int ErikLön = int.Parse(Erik);
            int MariaLön = int.Parse(Maria);
            int JimmieLön = int.Parse(Jimmie);

            int Medellön = (ErikLön + MariaLön + JimmieLön) / 3;

            Console.WriteLine("Medellönen för personalen är " + Medellön);
        }
    }
}