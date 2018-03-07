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
            Console.WriteLine("podaj 3 oceny i zatwierdz kazda przyciskiem enter");
            float q = float.Parse(Console.ReadLine());
            ///Console.Clear;
            float w = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());
            student xxx = new student(q, w, e);
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

    public student(float ocena1, float ocena2, float ocena3)
    {
        a = ocena1;
        b = ocena2;
        c = ocena3;
    }
    public float Sriednia()
    {
        Console.WriteLine("wartość średniej");
        return ((a + b + c) / 3);
    }
}
