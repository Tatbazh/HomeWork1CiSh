// входные данные - число N, выходные - все четные числа от 1 до N
Console.Clear();
Console.Write("Введите число N: ");

int N = int.Parse(Console.ReadLine()!); 
int number = 1;

while (number < N)
{
double result = number%2;

if (result == 0)
   {
    Console.Write($"{number}, ");
   }
   number++;
}
Console.Write($"-> четные числа от 1 до {N}");