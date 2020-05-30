using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    /* Mohammmad Aris Saputra
     * 18051204041
       TI 2018 B */
    class Hitung
    {
        public double tambah(double a, double b)
        {
         return a + b;
        }
        public double kurang(double a, double b)
        {
            return a - b;
        }
        public double perkalian(double a, double b)
        {
            return a * b;
        }
        public double pembagian(double a, double b)
        {
            return a / b;
        }
        public double seper(double a)
        {
            return 1/a;
        }
        public double persen(double a)
        {
            return a/100;
        }
        public double kuadrat(double a)
        {
            return a * a;
        }
        public double akar(double a)
        {
            return Math.Sqrt(a);
        }
        public double faktorial(double a)
        {
            double hasil = 1;
            for(double i=1; i<=a; i++)
            {
                hasil = hasil * i;
            }
            return hasil;
        }
        public double convert_Torad(double a)
        {
            return (a * Math.PI) / 180;
        }
        public double ht_sin(double a)
        {
            a = convert_Torad(a);
            return Math.Sin(a);
        }
        public double ht_cos(double a)
        {
            a = convert_Torad(a);
            return Math.Cos(a);
        }
        public double ht_tan(double a)
        {
            a = convert_Torad(a);
            return Math.Tan(a);
        }
        public double ht_cosec(double a)
        {
            a = convert_Torad(a);
            return 1/Math.Sin(a);
        }
        public double ht_sec(double a)
        {
            a = convert_Torad(a);
            return 1/Math.Cos(a);
        }
        public double ht_cot(double a)
        {
            a = convert_Torad(a);
            return 1/Math.Tan(a);
        }
    }
}
