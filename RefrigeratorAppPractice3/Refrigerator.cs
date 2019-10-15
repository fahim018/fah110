using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace RefrigeratorAppPractice3
{
    public class Refrigerator
    {
        public double max;
        List<double> CurrentWeight = new List<double>();
        List<double> Items = new List<double>();
        List<double> WeightByUnit = new List<double>();
        public double sum = 0;
        public double remainingWeight;

        public Refrigerator()
        {
            max = 2000;
        }

        public void Set(double item,double weight)
        {
            double currentWeight = item * weight;
            CurrentWeight.Add(currentWeight);
        }


        public double GetCurrentWeight()
        {
            sum = 0;
           
            foreach (var CW in CurrentWeight)
            {
                if (sum < max)
                {
                    sum = sum + CW;
                }
                else
                {
                    Console.WriteLine("Overflow");
                    return 0;
                }
                
            }

            return sum;

        }

        public double RemainingWeight()
        {
            remainingWeight = max - sum;
            return remainingWeight;
            
        }
    }
}
