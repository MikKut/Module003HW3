using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    public class Program
    {
        private const double NumberToCompare = 3;
        public static void Main()
        {
            var class2 = new Class2();
            var class1 = new Class1();
            class1.Del(class2.Calc(class1.Pow, 2, 3)(NumberToCompare));
        }

        public static void Show(bool predicateResult)
        {
            Console.WriteLine($"Result: {predicateResult}");
        }
    }
}