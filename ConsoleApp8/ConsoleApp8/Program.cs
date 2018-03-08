using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj nr ideksu");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj ocenę z WOS");
            float q = float.Parse(Console.ReadLine());
            ///Console.Clear;
            Console.WriteLine("podaj ocene MAT");
            float w = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj ocenę HIS");
            float j = float.Parse(Console.ReadLine());
            student xxx = new student(j, q, w, r);
            Console.WriteLine(xxx.Sriednia());
            Console.ReadKey();
        }
    }
}
class student
{
    public float a;
    public float b;
    public float c;
    public int d;

    public student(float WOS, float MAT, float HIS, int indeks)
    {
        a = WOS;
        b = MAT;
        c = HIS;
        d = indeks;

    }
    public float Sriednia()
    {
        Console.WriteLine("wartość średniej");
        return ((a + b + c) / 3);
    }
}
