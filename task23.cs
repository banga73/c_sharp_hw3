Console.WriteLine("Input number ");
int num1 = int.Parse(Console.ReadLine());
double[] cube1 = new double[num1];
for (int n = 1; n < num1; n++) {
	cube1[(n-1)] = Math.Pow(n, 3);
	Console.Write($"{cube1[n-1]}, ");
}
Console.Write(Math.Pow(num1, 3));