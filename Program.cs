namespace GitPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Програма обчислення площі та периметра прямокутника");

            Console.Write("Введіть довжину: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть ширину: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine($"Площа: {area}");
            Console.WriteLine($"Периметр: {perimeter}");
        }
    }
}