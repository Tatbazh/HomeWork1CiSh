// входные данные - 3 любых числа, выходные - max из этих чисел
Console.Clear();
Console.Write("Введите 1-ое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2-ое число: ");
int number2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите 3-е число: ");
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number2 > max) 
    {
        max = number2;
    }
    if (number3 > max)
    {
        max = number3;
    }
Console.WriteLine($"{max} - является max");