// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
double numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB )
    Console.WriteLine($"{numberA} > {numberB}");
else
{
    Console.WriteLine($"{numberA} < {numberB}");
}