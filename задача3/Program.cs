// Является ли заданное число четным?
Console.WriteLine("Ввведите число: number=");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2==0)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число нечетное");
}