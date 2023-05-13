using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    class TestGeometricalIncreace
    {
        public static void Main(string[] args)
        {
            TestGeometricalIncreace sol = new TestGeometricalIncreace();
            sol.Realize(10,200,0.02f);
        }
        public void Realize(float first, float steps, float basePerent)
        {
            float current = first;
            List<float> percents = new List<float>();
            percents = RandomizePercentsStage(101, 103, steps);
            for (int i = 1; i <= steps - 1; i++)
            {
                current *= percents[i];
                Console.WriteLine(current);
            }
        }
        public List<float> RandomizePercentsStage(int minPerc, int maxPerc, float steps)
        {
            List<float> percents = new List<float>();
            Random rnd = new Random();
            float checkValue = 0;
            for (int i = 0; i<=steps; i++)
            {
                float value = rnd.Next(minPerc, maxPerc);
                percents.Add(value/100);
                checkValue += value;
            }
            return percents;
        }
    }
}
