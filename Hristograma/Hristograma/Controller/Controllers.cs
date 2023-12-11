using Hristograma.Module;
using Hristograma.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hristograma.Controller
{
   public class Controllers
    {
        private readonly Models model;
        private readonly Views view;

        public Controllers(Models model, Views view)
        {
            this.model = model;
            this.view = view;
        }

        public void Procent()
        {
            model.P1 = Procent(model.Chisla, num => num < 200);
            model.P2 = Procent(model.Chisla, num => num >= 200 && num <= 399);
            model.P3 = Procent(model.Chisla, num => num >= 400 && num <= 599);
            model.P4 = Procent(model.Chisla, num => num >= 600 && num <= 799);
            model.P5 = Procent(model.Chisla, num => num >= 800);
        }

        private double Procent(List<int> numbers, Func<int, bool> condition)
        {
            int count = 0;
            foreach (var num in numbers)
            {
                if (condition(num))
                {
                    count++;
                }
            }
            //delka na count na obshtiq broi chisla igi obrushta v procenti
            return (double)count / model.Broi * 100;
        }

        public void Display()
        {
            view.Display(model);
        }
    }
}
