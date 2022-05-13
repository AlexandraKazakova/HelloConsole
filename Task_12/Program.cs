// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число ->");
int number = int.Parse(Console.ReadLine());
int res1 = number % 7;
int res2 = number % 23;
if(res1 == 0 && res2 == 0)
{
	Console.WriteLine("да");
}
else Console.WriteLine("нет");