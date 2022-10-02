// входные данные - число, выходные - четное ли число ("да", "нет")
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!); 
double result = number%2;
Console.WriteLine("Является ли оно четным?");

if (result == 0)
{
    Console.WriteLine($"{number} -> да");
}
else 
{
    Console.WriteLine($"{number} -> нет");
}