int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
int maxCount = 0;
for (int i = 0; i < arr.Length; i++)
{
    int count = 1;
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            count++;
        }
    }
    if (count > maxCount)
    {
        maxCount = count;
    }
}
Console.Write("The most frequent elements are: ");
for (int i = 0; i < arr.Length; i++)
{
    int count = 1;
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            count++;
        }
    }
    if (count == maxCount && Array.IndexOf(arr, arr[i]) == i)
    {
        Console.Write(arr[i] + " ");
    }
}