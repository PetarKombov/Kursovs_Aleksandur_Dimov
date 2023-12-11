using Hristograma.Module;
using System;

namespace Hristograma.View
{
    public  class Views
    {
        public void Display(Models model)
        {
            Console.WriteLine($"1 . . . 200: {model.P1:f2}%");
            Console.WriteLine($"200 . . . 399: {model.P2:f2}%");
            Console.WriteLine($"400 . . . 599: {model.P3:f2}%");
            Console.WriteLine($"600 . . . 799: {model.P4:f2}%");
            Console.WriteLine($"800  . . . 999: {model.P5:f2}%");
        }           
    }
}
