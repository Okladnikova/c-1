// 2 числа, проверить является ли первое квадратом второго
Console.WriteLine("Введите первое число: A=");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: B=");
double numberB = Convert.ToDouble(Console.ReadLine());
if (numberA==numberB*numberB)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}