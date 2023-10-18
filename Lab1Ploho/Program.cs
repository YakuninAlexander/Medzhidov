using System;

namespace Lab1Ploho
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(37, 53, 90, 3, 4, 5);
            Console.WriteLine(t.getInfo());
            Console.WriteLine(t.sOkr());
            Console.WriteLine(t.SOkr());
        }
    }
}
