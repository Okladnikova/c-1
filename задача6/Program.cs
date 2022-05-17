// Число из [10,99] показать наибольшую цифру числа
int a = new Random().Next(10,100);
Console.WriteLine(a);
int b=a%10;
Console.WriteLine(b);
int c=a/10;
Console.WriteLine(c);
Console.WriteLine("Наибольшая цифра числа");
if (b>c)
{
    Console.WriteLine(b);    
}
else
{
    Console.WriteLine(c);
}