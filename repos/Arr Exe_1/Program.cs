int[] arr = new int[] { 7, 4, 5, 6, 8, 2, 3, 1 };
int large = arr[0];
for(int i = 1; i < arr.Length; i++)
{
    if (arr[i] > large)
    {
        large = arr[i];
    }
}
Console.WriteLine("largest num in given arr is = " + large);