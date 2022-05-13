int number = new Random().Next(10, 100);
Console.WriteLine($"Number = {number}");
int maxNum = FindMaxNumber (number);
//int firstDigit = number / 10;
//int secondDigit = number % 10;
Console.WriteLine($"Max = {maxNum}");

int FindMaxNumber (int num)
{
	int firstDigit = num / 10;
	int secondDigit = num % 10;
	return firstDigit > secondDigit ? firstDigit : secondDigit;
}