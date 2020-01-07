using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else
            {
                Console.WriteLine("Please enter the package width:");
                float width = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                float length = float.Parse(Console.ReadLine());

                float sumDimensions = width + height + length;

                if (sumDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }

                else
                {
                    float shippingUnrounded = (sumDimensions * weight) / 100;
                    string shippingQuote = String.Format("{0:0.00}", shippingUnrounded);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + shippingQuote);
                    Console.WriteLine("Thank you.");
                }
                    
            }
            Console.ReadLine();
        }
    }
}
