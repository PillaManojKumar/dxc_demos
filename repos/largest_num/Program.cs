Console.WriteLine("Enter A num1");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter A num2");
int num2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter A num3");
int num3 = Convert.ToInt16(Console.ReadLine());

if(num1 > num2 && num1 > num3)
{
    Console.WriteLine("num1 is grater");
}
else if(num2 > num1 && num2 > num3)
{
    Console.WriteLine("num2 is grater");
}
else
{
    Console.WriteLine("num3 is grater");
}