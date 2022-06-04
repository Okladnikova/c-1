// посчитать сумму цифр в числе
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
//рядность числа
// int i=0; 
int sum = 0;
while (a!=0)
{
    int i=0; 
    sum=sum+a%10;
    a=a/10;
    i++;
}
Console.WriteLine(sum);