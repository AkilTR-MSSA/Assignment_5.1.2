Console.Write($"Enter a number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of the digits of the number {x} is: {SumDigits(x)}");

int SumDigits(int x)
{
    int sum = 0;
    while (x > 0)
    {
        int digit = x % 10;
        sum += digit;
        x /= 10;
    }
    return sum;
}