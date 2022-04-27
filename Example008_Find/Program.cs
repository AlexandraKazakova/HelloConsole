int[] array = {3,4,67,23,43,4,87,42};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
	if (array[index] == find)
	{
		Console.WriteLine(index);
		break;
	}
	index++;
}