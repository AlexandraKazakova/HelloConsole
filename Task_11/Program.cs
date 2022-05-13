// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно
// первому числу, то программа выводит остаток от деления.
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
int resalt = number1 % number2;
if(resalt == 0)
{
	Console.WriteLine($"{number1}, {number2} -> кратно");
}
else
{
	Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {resalt}");
}