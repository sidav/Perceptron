using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Perceptron
    {
        const int gridSize = Grid.gridSize;
        int[] inputs;
        double[] w;
        //static double theta = 0.5;
        const double eta = 0.5;

        public string category1;
        public string category2;

        int f()
        {
            double sum = 0;
            for (int i = 0; i <= gridSize * gridSize; i++)
                sum += inputs[i] * w[i];
            if (sum < 0)
                return 0;
            return 1;
        }

        public Perceptron()
        {
            inputs = new int[gridSize*gridSize+1];
            w = new double[gridSize*gridSize+1];
            Random rnd = new Random();
            for (int i = 0; i <= gridSize * gridSize; i++)
                w[i] = (double)(rnd.Next(10)+1)/100;
            Console.Write("Nexus "+gridSize+" initialized.");
            category1 = "А";
            category2 = "Б";
        }

        public void DeltaRule()
        {
            int delta = 0;
            if (f() == 1)
                delta = -1;
            else
                delta = 1;
            for (int i = 0; i <= gridSize * gridSize; i++)
                w[i] += eta * delta * inputs[i];
            //Console.Write("Punishment applied.");
        }

        public int Recognize()
        {
            inputs[0] = 1;
            for (int i = 0; i < gridSize; i++)
                for (int j = 0; j < gridSize; j++)
                    if (Grid.input[i, j])
                        inputs[i * gridSize + j + 1] = 1;
                    else
                        inputs[i * gridSize + j + 1] = 0;
            return f();
        }

        public void setCat1(string cat)
        {
            category1 = cat;
        }

        public void setCat2(string cat)
        {
            category2 = cat;
        }

    }
}
