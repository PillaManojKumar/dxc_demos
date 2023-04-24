int[] numbers = new int[10];
int sum = 0;

Console.WriteLine("Enter 10 integers:");
for (int i = 0; i < 10; i++)
{
    Console.Write("Enter integer {0}: ", i + 1);
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    sum += numbers[i];
}

double average = (double)sum / 10;
Console.WriteLine("The average of the 10 integers is: {0}", average);