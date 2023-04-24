int[] arr = new int[10];
int count = 0;
Console.WriteLine("Enter 10 numbers: ");
for (int i = 0; i < 10; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 10; i++)
{
    for(int j = i + 1; j < 10; j++)
    {
        if (arr[i] == arr[j])
        {
            count++;
            break;
        }
    }    
}
Console.WriteLine("Number of duplicate values in the array = {0}", count);
