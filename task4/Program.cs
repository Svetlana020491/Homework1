﻿//  Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N. 
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int multiplicity = 2;

while (multiplicity <= number )

{  
      Console.Write($"{multiplicity} ");
      multiplicity += 2;
}
Console.WriteLine( );






