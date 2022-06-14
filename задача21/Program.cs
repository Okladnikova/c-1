// Задать массив, заполнить трехзначными числами, показать количесвто четных и нечетных чисел
void FillArray(int[]array)
{
    int index=0;
    int count1=0;
    int count2=0;
for(index=0;index<array.Length;index++)
{
    array[index]= new Random().Next(100,1000);
    if (index%2==0)
    {
        count1=count1+1;
    }
        else
    {
        count2=count2+1;
    }
}
Console.WriteLine($"количество четных чисел {count1}");
Console.WriteLine($"количество нечетных чисел {count2}");
}
void PrintArray(int[]array1)
{
    int position=0;
    for (position=0; position<array1.Length; position++)
    {
    Console.WriteLine(array1[position]);
    }
}
int[]array=new int[900];
FillArray(array);
PrintArray(array);
