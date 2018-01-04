using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new BoadRepository();

            var boad = repo.GetByBreed<Boad>("Boad дуб");
            var roll = repo.GetByBreed<Roll>("Oak");
            Console.WriteLine($"Boad length: {boad.Length}");
            Console.WriteLine($"Roll width: {roll.Width}");

            Console.ReadKey();
        }
    }
}
