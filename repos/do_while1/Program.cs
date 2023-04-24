Console.WriteLine("Enter the 5 digit number");
long num = Convert.ToInt64(Console.ReadLine());

long sum = 0;
while (num != 0)
{
    sum = sum + (num % 10);
    num = num / 10;
}
Console.WriteLine("Sum of 5 digit num is = " + sum);
