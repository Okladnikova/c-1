// Возведите число a в натуральную степень b через цикл
Console.WriteLine("Введите число а");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень b");
int b= Convert.ToInt32(Console.ReadLine());
int i =1;
int count=1;
while (i<=b)
{
 count*=a;   
 i++;
}
Console.WriteLine(count);
