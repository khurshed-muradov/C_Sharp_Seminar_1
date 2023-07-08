// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые цифры в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()); // 4
int start = N * (-1); // -N -4
while (start <= N)
{
    Console.Write(start + " ");
    start = start + 1;
}
