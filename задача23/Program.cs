// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int [] array={1,2,3,4,5,6,7,8,9,10,11};
int n=array.Length-1;
int result=0;
int i=0;
while (i<=array.Length/2)
{
   result=array[i]*array[n];
   n--;
   i++;
   Console.WriteLine(result);
}
//Console.WriteLine(result);
