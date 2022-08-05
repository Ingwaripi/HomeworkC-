// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> н

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int square = num1 % 2;
Console.WriteLine(square); 
if (square == 0)
{
    Console.WriteLine($"Чисkо {num1} является четным"); 
}
else
{
    Console.WriteLine($"Чисkо {num1} не является четным"); 
}