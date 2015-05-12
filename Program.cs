using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            shoes myNewShoes = new shoes();

            myNewShoes.Size = 7;
            myNewShoes.Colour = "red";
            myNewShoes.Material = "leather";

            Console.WriteLine("{0} - {1} - {2}",
            myNewShoes.Size,
            myNewShoes.Colour,
            myNewShoes.Material);
                

            Console.ReadLine();
        }
   }

    class shoes
    {
        public int Size { get; set; }
        public string Colour { get; set; }
        public string Material { get; set; }
    }

}
