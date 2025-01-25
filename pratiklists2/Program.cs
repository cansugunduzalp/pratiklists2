using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> kahveler = new List<string>();

        // Kullanıcıdan 5 kahve ismi alıyoruz
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Kahve {i}:");
            string kahveIsmi = Console.ReadLine();
            kahveler.Add(kahveIsmi);
        }

        // Listeyi foreach döngüsü ile yazdırıyoruz
        Console.WriteLine("\nGirdiğiniz kahve isimleri:");
        foreach (string kahve in kahveler)
        {
            Console.WriteLine(kahve);
        }
    }
}
