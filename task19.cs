Console.WriteLine("Input five-dight number ");
int num1 = int.Parse(Console.ReadLine());
if (num1 < 10000 || num1 > 99999) Console.Write("Wrong format!");
else {
	int d1 = (num1 / 10000) % 10;
	int d2 = (num1 / 1000) % 10;
	int d3 = (num1 / 100) % 10;
	int d4 = (num1 / 10) % 10;
	int d5 = num1 % 10;
	if (d5 == d1 && d4 == d2) Console.Write("Yes");
	else Console.Write("No");
}