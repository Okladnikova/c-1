// Кратно ли число заданному, если нет вывести остаток
Console.WriteLine ("введите числа a и b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = a%b;
if (c==0)
{
    Console.WriteLine("a кратно b");
}
else
{
    Console.WriteLine($"остаток от деления a на b {c}");
}