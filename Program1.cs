Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    int max = a;
    Console.Write("max = ");
    Console.WriteLine(a);
}
if (a < b)
{
    int max = b;
    Console.Write("max = ");
    Console.WriteLine(b);
}
