// Пересечение двух прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2. Значения задает пользователь.
Console.Write("Введите значение b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение к1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение к2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Intersection point: ({x} ; {y})");