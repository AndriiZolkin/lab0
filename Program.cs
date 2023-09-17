using System; 
internal class Program
{
    static double SubtractionOfNumbers(double number1, double number2)
    {
        return number1 - number2;
    }
    static void Main()
    {
        Random random = new Random();
        double number1 = random.NextDouble() * 100 - 50 ;
        double number2 = random.NextDouble() * 100 - 50 ;
        double result = SubtractionOfNumbers(number1, number2);
        
        Console.WriteLine(" Вариант 6 (Реализовать функцию вычисления разности двух вещественных чисел)");
        if (number2 >= 0)
        {
            Console.WriteLine($"{number1} - {number2} = {result}");
        }
        else
        {
            Console.WriteLine($"{number1} - ({number2}) = {result}");
        }
    }
    
}