using System;
namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            bool Task1(int a, int b, int c)
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    return true;
                }
                else if (a < 0 && b < 0 && c < 0)
                {
                    return true;
                }
                else if (a == 0 && b == 0 & c == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            answer = Task1(a, b, c);
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            bool Task2(int a, int b)
            {

                if (b != 0 && a % b == 0)
                {
                    return true;
                }
                else if (a != 0 && b % a == 0) {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            answer = Task2(a, b);
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here


            bool Task3(int a, int b)
            {

                if (Math.Pow(a, 2) == b || Math.Pow(b, 2) == a)
                {
                    return true;
                }
                else if (Math.Pow(a, 3) == b || Math.Pow(b, 3) == a)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            answer = Task3(a, b);
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double Task4(double d, double f, double g)
            {
                double x = (Math.Pow(f, 2) - 4 * d * g);

                return x;

            }

            answer = Task4(d, f, g);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double Task5(double x)
            {
                if (x <= -1)
                {
                    return 1;
                }
                else if (x > -1 && x <= 1)
                {
                    return -x;
                }
                else
                {
                    return -1;
                }
            }

            answer = Task5(x);
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            bool Task6(double sqar, double circar)
            {
                double sqside = Math.Sqrt(sqar);
                double radius = sqar / 2;

                if (Math.PI * (Math.Pow(radius, 2)) == circar)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            answer = Task6(squareS, circleS);
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            
            // end

            return answer;
        }
    }
}