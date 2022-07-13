// Написать программу, которая переворачивает массив.Первый элемент с последним и т.д.
Console.WriteLine("Задайте длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
for (int i = 0; i < array.Length; i++)
{
     array[i] = new Random().Next(100,999);
}
Console.WriteLine("["+string.Join(",",array)+ "]");
for (int i = 0 ; i < array.Length/2; i++)
{
   (array[i], array[array.Length - (i+1)]) = (array[array.Length - (i+1)], array[i]); 
}
Console.WriteLine("Массив перевернут: ");
Console.WriteLine("["+string.Join(",",array)+ "]");