// Напишите программу. которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите числа: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
