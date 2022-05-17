// Показать вторую цифру трехзначного числа,удалить ее,найти 3 цифру числа или сообщить что ее нет
Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int k = n%100;
int t = k/10; //вторая цифра
int a = n%10; //третья цифра
int b = n/100; //первая цифра
Console.WriteLine($"Вторая цифра числа {t}");
//Удалить вторую цифру числа
Console.Write(b);
Console.WriteLine(a);
if(n < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра {a}");
}