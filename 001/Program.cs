// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// // int number = Int.Parse(Console.ReadLine())


// // int sqr = number * number;

// // Console.Write($"Квадрат числа {number} равен: {sqr}");
// Console.Write($"Квадрат числа {number} равен: {number * number}");


Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
Console.Write($"Число {numberA} является квадратом {numberB}");
}
    
else
    Console.Write($"Число {numberA} не является квадратом {numberB}");