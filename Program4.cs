Console.WriteLine("Enter your number");
int N = Convert.ToInt32(Console.ReadLine());
int b = 1;;
while (b < N)
{
    if (b % 2 == 0)
        if (b == N - 1)
            Console.Write($"{b}");
        else
            Console.Write($"{b}, ");
    b++;
}