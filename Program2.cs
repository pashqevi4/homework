Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b)
    if (a > c)
            max = a;
        else
            max = c;
else
    if (b > c)
            max = b;
        else
            max = c;
Console.Write("Max number = ");
Console.WriteLine(max);