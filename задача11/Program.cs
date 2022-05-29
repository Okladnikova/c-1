// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти от 1 до 4");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter==1)
{
    Console.WriteLine("Координаты x>0 y>0");
}
if (quarter==2)
{
    Console.WriteLine("Координаты x>0 y<0");
}
if (quarter==3)
{
    Console.WriteLine("Координаты x<0 y<0");
}
if (quarter==4)
{
    Console.WriteLine("Координаты x<0 y>0");
}