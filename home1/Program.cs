// Сколко чисел больше 0 ввел пользователь.
int n;
Console.WriteLine("Введите количество чисел: ");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
Console.WriteLine("Введите числа: ");
int count = 0;
for (int i =0; i < array.Length; i++)
{
  array[i] = Convert.ToInt32(Console.ReadLine());
  if (array[i] >0)
  count += 1;
}
Console.WriteLine("Количество чисел: ");
Console.WriteLine(count);
