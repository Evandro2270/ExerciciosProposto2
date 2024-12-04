using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Programa
{
    using System;

    namespace URI
    {
        class Program
        {
            static void Main(string[] args)
            {
                CultureInfo CI = CultureInfo.InvariantCulture;

                double R, A, Pi = 3.14159;

                R = double.Parse(Console.ReadLine(), CI);
                A = Pi * R * R;

                Console.WriteLine("A= " + A.ToString("F4", CI));

            }
        }
    }
}