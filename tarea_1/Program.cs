using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraccion a = new Fraccion(2, 6);
            Fraccion b = new Fraccion();
            Fraccion c = a + b;
            Fraccion d = a - b;
            Fraccion e = a * b;
            Fraccion f = a / b;
            Console.WriteLine("primer valor");
            a.imprime();
            Console.WriteLine("segundo valor");
            b.imprime();
            Console.WriteLine("suma:");
            c.imprime();
            Console.WriteLine("resta:");
            d.imprime();
            Console.WriteLine("multiplicacion:");
            e.imprime();
            Console.WriteLine("divicion:");
            f.imprime();
            Console.ReadKey();
        }
    }
    class Fraccion
    {
        private int num;
        private int den;
        public Fraccion(int num,int den)
        {
            this.num = num;
            this.den = den;
        }
        public Fraccion()
        {
            num = 5;
            den = 4;
        }
        public void imprime()
        {
            Console.WriteLine("{0}/{1}", num, den);
        }
        public decimal a_decimal()
        {
            return num / den;
        }
        public static Fraccion operator + (Fraccion x,Fraccion y)
        {
            Fraccion result = new Fraccion(x.num * y.den + x.den * y.num, x.den * y.den);
            return result;

        }
        public static Fraccion operator -(Fraccion x, Fraccion y)
        {
            
            Fraccion result2 = new Fraccion(x.num * y.den - x.den * y.num, x.den * y.den);
            
            return result2;
        }
        public static Fraccion operator *(Fraccion x, Fraccion y)
        {

            Fraccion result3 = new Fraccion(x.num * y.num, x.den * y.den);

            return result3;
        }
        public static Fraccion operator /(Fraccion x, Fraccion y)
        {

            Fraccion result4 = new Fraccion(y.den * x.num, y.num * x.den);

            return result4;
        }
    }
}