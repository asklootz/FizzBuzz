int x = 1;
int userNum;

Console.WriteLine("Enter a number: ");
userNum = int.Parse(Console.ReadLine());

while (x <= userNum)
{
	if (x % 3 == 0 && x % 5 == 0)
	{
		Console.WriteLine("FizzBuzz");
	}
	else if (x % 3 == 0)
	{
		Console.WriteLine("Fizz");
	}
	else if (x % 5 == 0)
	{
		Console.WriteLine("Buzz");
	}
	else
	{
		Console.WriteLine(x);
	}
	x++;
};
