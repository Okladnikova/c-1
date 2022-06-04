//Показать кубы чисел,заканчивающиеся на четную цифру
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<=N)
{
   
    Double n3 = Math.Pow(i,3);
    if (n3%2==0)
    {
        Console.WriteLine(n3);
    }
    i++;
}