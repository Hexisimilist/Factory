using Factory.Domain;
using Factory.Factories;


class Program
{
    static void Main()
    {
        Console.WriteLine("> N - Netflix\n> Y - Youtube");

        string subtype = Console.ReadLine();

        GetSubFactory factory = GetFactory(subtype);

        ISubscription sub = factory.GetSubscription();

        Console.WriteLine("\n> Sub bought: \n");

        Console.WriteLine(
            $"\tName:\t\t{sub.Name}\n" +
            $"\tDescription:\t{sub.Description}\n" +
            $"\tPrice:\t\t{sub.GetPrice()}");

        Console.ReadLine();
    }

    private static GetSubFactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "n" => new NetflixFactory(100, "Netflix Sub"),
            "y" => new YoutubeFactory(200, "Youtube Sub"),
            _ => null
        };
}