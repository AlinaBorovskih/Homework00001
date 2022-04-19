Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

if ((numberA % 2) ==0)
{
    Console.WriteLine($"вывести чётное число {numberA}");
}
else
{
    Console.WriteLine($"вывести нечётное число {numberA}");
}
