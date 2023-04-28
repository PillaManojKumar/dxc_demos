class MyStack<T>
{
    int capacity;
    T[] stack;
    int top;

    public MyStack(int MaxElements)

    {
        capacity = MaxElements;

        stack = new T[capacity];
    }



    public int push(T Element)

    {


        if (top == capacity - 1)

        {

            return -1;

        }

        else

        {

            top = top + 1;

            stack[top] = Element;

        }

        return 0;

    }



    public T pop()

    {

        T RemovedElement;

        T temp = default(T);

        if (!(top <= 0))

        {

            RemovedElement = stack[top];

            top = top - 1;

            return RemovedElement;

        }

        return temp;

    }







    public T[] GetAllStackElements()

    {

        T[] Elements = new T[top + 1];

        Array.Copy(stack, 0, Elements, 0, top + 1);

        return Elements;

    }

}

class program
{
    static void Main(string[] args)

    {

        int capacity;

        Console.WriteLine("Enter Capacity of Stack :");

        capacity = Convert.ToInt32(Console.ReadLine());



        MyStack<string> stack = new MyStack<string>(10);



        while (true)

        {

            Console.WriteLine("1.Push");

            Console.WriteLine("2.Pop");

            Console.WriteLine("3.Print Stack Elements:");

            Console.WriteLine("4.Exit");



            Console.WriteLine("Enter your Choice :");

            int choice = Convert.ToInt32(Console.ReadLine());



            switch (choice)

            {

                case 1:

                    {

                        Console.WriteLine("Enter String to Push :");

                        string temp = Console.ReadLine();

                        int result = stack.push(temp);



                        if (result != -1)

                        {

                            Console.WriteLine("Element Pushed into Stack !");

                        }

                        else

                        {

                            Console.WriteLine("Stack Overflow !");

                        }

                        break;

                    }

                case 2:

                    {

                        string Result = stack.pop();

                        if (Result != null)

                        {

                            Console.WriteLine("Delete Element :" + Result);

                        }

                        else

                        {

                            Console.WriteLine("Stack Underflow !");

                        }

                        break;

                    }

                case 3:

                    {

                        string[] Elements = stack.GetAllStackElements();

                        Console.WriteLine("**************Stack Content **************");

                        foreach (string str in Elements)

                        {

                            Console.WriteLine(str);

                        }

                        break;

                    }

                case 4:

                    {

                        System.Diagnostics.Process.GetCurrentProcess().Kill();

                        break;

                    }

                default:

                    {

                        Console.WriteLine("You have Entered Wrong Choice ");

                        break;

                    }

            }

        }

    }
}
