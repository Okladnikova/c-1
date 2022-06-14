// задать массив из 12 эл-в и заполнить элементами от 0 до 9 включительно, найти сумму + и - элементы массива
void FillArray (int[]a)
{
    int n= a.Length;
    int index=0;
    int sum=0;
    while (index<n)
    {
        a[index]= new Random().Next(-9,10);
        sum=sum+a[index];
        index++;
    }
    Console.WriteLine ($"Сумма элементов массива равна {sum}");
    }
void PrintArray (int[]b)
{
    int m=b.Length;
    int position=0;
    while (position<m)
    {
        Console.WriteLine(b[position]);
        position++;
    }
}
int[]array=new int[12];
FillArray(array);
PrintArray(array);
