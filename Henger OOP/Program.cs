using Henger_OOP;

internal class Program
{

    static void list (List<Henger> hengerek)
    {
        foreach (var henger in hengerek)
        {
            Console.WriteLine(henger);
        }
    }
    static void Main(string[] args)
    {
        List<Henger> Test = new List<Henger>();




        Test.Add(new Henger(1, 4));
        Test.Add(new TomorHenger(0.5, 4, 2));
        Test.Add(new TomorHenger(0.5, 4));
        Test.Add(new Cso(5, 5, 0.5));
        Test.Add(new Cso(5, 5));

        list(Test);

        Console.WriteLine("Testek száma:" + Test.Count);
        Console.WriteLine("Létrehozott hengerek száma:" + Henger.SzuletesSzamlalo);

    }
}