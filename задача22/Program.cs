// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray(int []array1)
{
    int index=0;
    int count=0;
    for (index=0; index<array1.Length;index++)
    {
        array1[index]= new Random().Next(20);
    if (array1[index]<100 && array1[index]>9)
        {
        count++;
        }
    }
    Console.WriteLine($"Количество элементов из отрезка 10,99= {count}");
}

void PrintArray(int[]array2)
{
    int index1=0;
    for (index1=0; index1<array2.Length;index1++)
    {
        Console.WriteLine(array2[index1]);
    }
}
int []array=new int [123];
FillArray(array);
PrintArray(array);
