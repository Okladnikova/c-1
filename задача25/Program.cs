// Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.WriteLine("Введите количество строк в массиве");
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int m= Convert.ToInt32(Console.ReadLine());
int [,] matrix= new int[n,m];
Random rand = new Random();
for (int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0;j<matrix.GetLength(1);j++)
    {
        matrix[i,j]=i+j;
        Console.Write($"{matrix[i,j]} ");
        
    }
Console.WriteLine();    
}
