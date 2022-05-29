// Дано число, обозначающий день недели. Определить является ли этот день выходным
Console.WriteLine("Ввведите номер дня недели от 1 до 7: numberday=");
int numberday = Convert.ToInt32(Console.ReadLine());
if (numberday==6)
{
   Console.WriteLine("Это суббота, Ура Выходной!");
}
if (numberday==7)
{
   Console.WriteLine("Это воскресенье, Ура Выходной");
}
else
{
    Console.WriteLine("Это будний день!");
}