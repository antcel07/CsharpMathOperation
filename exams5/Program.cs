using System;

namespace exams5
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation operation = new MathOperation();
           
            Console.WriteLine("9 + 3 = " + operation.Add(9, 3));
            Console.WriteLine("9 - 3 = " + operation.Sub(9, 3));
            Console.WriteLine("9 * 3 = " + operation.Mul(9, 3));
            Console.WriteLine("9 / 3 = " + operation.Div(9, 3));
            
            Console.ReadKey();
        }

              public interface IMath
        {
            double Add(double x, double y);
            double Sub(double x, double y);
            double Mul(double x, double y);
            double Div(double x, double y);
        }
      
        public class Math : IMath
        {
            public double Add(double x, double y) { return x + y; }
            public double Sub(double x, double y) { return x - y; }
            public double Mul(double x, double y) { return x * y; }
            public double Div(double x, double y) { return x / y; }
        }
      
        public class MathOperation : IMath
        {
            private Math math = new Math();
            public double Add(double x, double y)
            {
                return math.Add(x, y);
            }
            public double Sub(double x, double y)
            {
                return math.Sub(x, y);
            }
            public double Mul(double x, double y)
            {
                return math.Mul(x, y);
            }
            public double Div(double x, double y)
            {
                return math.Div(x, y);
            }
        }
    }
    }

