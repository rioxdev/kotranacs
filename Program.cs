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

            var json = JsonSerializer.Serialize(alexis, options: new JsonSerializerOptions() { WriteIndented = true});
            Console.WriteLine(json);

        }
    }
}