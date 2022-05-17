// По заданному номеру дня недели определить его название
Console.WriteLine("Ввведите номер дня недели: numberday=");
int numberday = Convert.ToInt32(Console.ReadLine());
//if (numberday==1) numberday = Console.WriteLine("Понедельник");
if (numberday==1)
{
   Console.WriteLine("Понедельник");
}
if (numberday==2)
{
   Console.WriteLine("Вторник");
}
if (numberday==3)
{
   Console.WriteLine("Среда"); 
}
if (numberday==4)
{
   Console.WriteLine("Четверг"); 
}
if (numberday==5)
{
   Console.WriteLine("Пятница"); 
}
if (numberday==6)
{
   Console.WriteLine("Суббота"); 
}
if (numberday==7)
{
   Console.WriteLine("Воскресенье"); 
}