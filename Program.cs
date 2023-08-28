using System.Text.Json;

namespace kotranacs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kotrana cs");

            var alexis = new Contact("Alexis", "Sanchez", "asanchez@gmail.com");
            Console.WriteLine(alexis);

            var (_, _, alexisEmail) = alexis;
            Console.WriteLine(alexisEmail);

            var json = JsonSerializer.Serialize(alexis, options: new JsonSerializerOptions() { WriteIndented = true });
            Console.WriteLine(json);

            var copied = new Contact("Alexis", "Sanchez", "asanchez@gmail.com");
            Console.WriteLine($"alexis == copied? {copied == alexis}");

            var rio = alexis with { FirstName = "Rio", Email = "rsanchez@gmail.com" };
            Console.WriteLine(rio);
            Console.WriteLine($"alexis == rio? {rio == alexis}");

        }
    }
}