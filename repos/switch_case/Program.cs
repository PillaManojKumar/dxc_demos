Console.WriteLine("Enter First Number");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int num2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter The operator");
char opert = Convert.ToChar(Console.ReadLine());
 

switch (opert)
{
    case '+':
        {
            int result = num1 + num2;
            Console.WriteLine("Result is = " +result);
            break;
        }
    case '-':
        {
            int result = num1 - num2;
            Console.WriteLine("Result is = " + result);
            break;
    }
    case '*':
        {
        int result = num1 * num2;
        Console.WriteLine("Result is = " + result);
        break;
    }
    case '%':
        {
        int result = num1 % num2;
        Console.WriteLine("Result is = " + result);
        break;
    }
    case '/':
        {
            int result = num1 - num2;
            Console.WriteLine("Result is = " + result);
            break;
        }
    default:
        {
            Console.WriteLine("Wrong operator");
            break;
        }

}
