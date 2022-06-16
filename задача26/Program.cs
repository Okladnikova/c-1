// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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
        matrix[i,j]= new Random().Next (2,3);
        Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine();    
}
void ChangeEvenElements(int[,] matrix)
{
for (int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0;j<matrix.GetLength(1);j++)
    {
        if (i!=0 & j!=0)
        {
            if (i%2==0 & j%2==0) matrix[i,j]= matrix[i,j]*matrix[i,j];
        }
    Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine(); 
}
}
Console.WriteLine();
ChangeEvenElements(matrix);
