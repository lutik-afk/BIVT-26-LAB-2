using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;
            int i;
            
            // code here
            for (i = 2; i <= n; i += 2)
   
                answer = answer+(i / (i + 1.0));
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            
            
            for (int i = 0; i <= n; i += 1)
                answer = answer + Math.Pow(x, -i);

            // code here

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long result = 1;
            if (n < 0)
                return 0;
            // code here
            answer = 1;
            for (int i = 1; i <= n; i += 1)
            {
                result *= i;
                answer = answer + result;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            int i = 1;
            double sum = Math.Pow(10, -4);
            double a = Math.Sin(i * Math.Pow(x, i));

            // code here
            while (Math.Abs(a) >= sum)
            {
                answer = answer + a;
                i += 1;
                a = Math.Sin(i * Math.Pow(x, i));
                
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            
            int n=1;
            double first = 1 / Math.Pow(x, n);
            double second= 1 / Math.Pow(x,  (n - 1));
            // code here
            while(Math.Abs(first-second)>=Math.Pow(10,-4) )
            {
                n += 1;
                first = 1 / Math.Pow(x, n);
                second = 1 / Math.Pow(x, (n - 1));
            }
            // end

            return n;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            int i = 0;
            
            // code here
            while (elem < limit)
            { elem *= 2;
                answer += elem;
                i ++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            double D=L;
            int i=0;
            // code here
            while (D > Da)
            {
                D = D / 2;
                i += 1;
            }
            // end

            return i;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            // code here
            for (double x = a; x <= b+h/1000; x += h)
            {
                if(Math.Abs(x)>1)
                {
                    SY += Math.Atan(x);
                    continue;
                }
                double sum = 0;
                double drob = x;
                int i = 0;
                while(true)
                {
                    sum += drob;
                    if (Math.Abs(drob) < 0.0001)
                        break;
                    i += 1;
                    drob *= -x * x * (2 * i - 1) / (2 * i + 1);
                }
                SS += sum;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}

//отправкааа