using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class RandomNumber
    {
        public int GetRandomNumber(List<double> items)
        {
            Random r = new Random();
            double rand = r.NextDouble();

            double probability = 0.0;
            double sum = 0.0;
            int selectedElement = 0;
            for (int i = 0; i < items.Count; i++)
                sum += items[i];
            for (int i = 0; i < items.Count; i++)
            {
                probability += items[i]/sum;
                if (rand < probability)
                {
                    selectedElement = i;
                    break;
                }
            }
            return selectedElement;
        }
    }
}
