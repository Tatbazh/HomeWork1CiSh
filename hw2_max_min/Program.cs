// входные данные - 2 любых числа, выходные - определить какое число max, а какое min
Console.Clear();
Console.Write("Введите 1-ое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2-ое число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 < number2) 
{
   Console.WriteLine($"{number1} - min, {number2} - max");
}
else 
{
    Console.WriteLine($"{number1} - max, {number2} - min");
}