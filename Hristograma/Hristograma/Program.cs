using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hristograma.View;
using Hristograma.Module;
using Hristograma.Controller;

namespace Hristograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            Models model = new Models(n, numbers);
            Views view = new Views();
            Controllers controller = new Controllers(model, view);

            controller.Procent();
            controller.Display();
        
        }
    }
}
