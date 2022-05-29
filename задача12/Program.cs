// Найти расстояние между точками в пространстве
Console.WriteLine("Введите координа точки A =(x;y;z)");
Double xA = Convert.ToDouble(Console.ReadLine());
Double yA = Convert.ToDouble(Console.ReadLine());
Double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координа точки B =(x;y;z)");
Double xB = Convert.ToDouble(Console.ReadLine());
Double yB = Convert.ToDouble(Console.ReadLine());
Double zB = Convert.ToDouble(Console.ReadLine());
Double C = Math.Sqrt ((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
Console.WriteLine($"Расстояние между точками А и В ={C}");