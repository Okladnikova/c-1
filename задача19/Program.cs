// задать массив из 8 элементов, заполненый 0 и 1 и вывести на экран
void FillArray(int[]a)
{
    int n= a.Length;
    int index=0;
while(index<n)
    {
    a[index]=new Random().Next(0,2);
    index++;
    }
}
void PrintArray(int[]b)
{
    int m= b.Length;
int position=0;
while(position<m)
    {
    Console.WriteLine(b[position]);
    position++;
}
}
int[]array = new int[8];
FillArray(array);
PrintArray(array);
