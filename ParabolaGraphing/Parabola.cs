using System;
using System.Collections.Generic;
using System.Text;

namespace ParabolaGraphing
{
    // A parabola in the form y = ax^2 + bx + c
    class Parabola
    {
        // Default values for parabola
        public Parabola()
        {
            a = 1;
            b = 2;
            c = 1;
        }

        // Constructor that builds parabola based on given arguments.
        public Parabola(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            BuildGraph();
        }

        private double a { get; set; }       // a * x^2
        private double b { get; set; }       // b * x
        private double c { get; set; }       // Constant c
        StringBuilder graph { get; }         // The graph

        // Actually writes the graph to the console.
        public void Graph()
        {
            Console.WriteLine(a);
        }

        // Only this class uses this.  Makes the graph so that it's ready to be printed.
        private void BuildGraph()
        {
            // I'm representing points as 2 dimensional arrays where [0] = x and [1] = y.
            double[] vertex = { -b / (2 * a), a * Math.Pow(-b / (2 * a), 2) + b * (-b / (2 * a)) + c };

            // Getting 10 points from the left and right of the vertex.
            List<double[]> points = new List<double[]>();

            Console.WriteLine(a);
        }

        // Use quadratic formula to find the X-intercepts of the parabola, if they exist.
        // POSSIBLE FEATURE: Even if the zeros are imaginary, show them.
        public List<string> X_Intercepts()
        {
            // Note that zeroes and x-intercepts mean the same thing

            List<string> zeroes = new List<string>();

            double discriminant = Math.Pow(b, 2.0) - 4 * a * c;
            // Evaluate the discriminant: b^2 - 4ac.  Zeroes... 2 if positive, 1 if 0, 2 imaginary if negative.
            // Complete quadratic formula when discriminant is found.
            if (discriminant > 0)   // 2 real zeroes
            {
                // 2 Zeroes
                zeroes.Add(String.Format("{0:F2}",(-b + Math.Sqrt(discriminant)) / (2 * a)));
                zeroes.Add(String.Format("{0:F2}", (-b - Math.Sqrt(discriminant)) / (2 * a)));
            }
            else if (discriminant == 0)
            {
                // 1 Zero
                zeroes.Add(String.Format("{0:F2}",-b / (2 * a)));
            }
            else
            {
                // 2 Imaginary zeros
                zeroes.Add(String.Format("({0:F2} + {1:F2}i) / {2:F2}", -b, Math.Abs(discriminant), 2 * a));
                zeroes.Add(String.Format("({0:F2} - {1:F2}i) / {2:F2}", -b, Math.Abs(discriminant), 2 * a));
            }

            return zeroes;
        }
    }
}
