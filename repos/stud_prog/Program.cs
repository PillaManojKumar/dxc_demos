Console.WriteLine("Enter the studentID");
int ID = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the student name");
string name = (Console.ReadLine());
Console.WriteLine("Enter the student age");
int age = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter marks1");
int marks1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter marks2");
int marks2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter marks3");
int marks3 = Convert.ToInt16(Console.ReadLine());
double tot, per;
int overall = 300;

tot = marks1 + marks2 + marks3;
per = (tot / overall) * 100;

if( per > 50)
{
    if(per > 90 && per < 100)
    {
        Console.WriteLine("Your total score is = " + tot);
        Console.WriteLine("Your per is =" + per);
        Console.WriteLine("Your grade is A");
        Console.WriteLine("Your result for the exam is pass");
    }
    else if(per > 80 && per < 89)
    {
        Console.WriteLine("Your total score is = " + tot);
        Console.WriteLine("Your per is =" + per);
        Console.WriteLine("Your grade is B");
        Console.WriteLine("Your result for the exam is pass");
    }
    else if (per > 60 && per < 79)
    {
        Console.WriteLine("Your total score is = " + tot);
        Console.WriteLine("Your per is =" + per);
        Console.WriteLine("Your grade is C");
        Console.WriteLine("Your result for the exam is pass");
    }
    else if (per > 50 && per < 59)
    {
        Console.WriteLine("Your total score is = " + tot);
        Console.WriteLine("Your per is =" + per);
        Console.WriteLine("Your grade is D");
        Console.WriteLine("Your result for the exam is pass");
    }
}
else
{ 
    Console.WriteLine("Your total score is = " + tot);
    Console.WriteLine("Your per is =" + per);
    Console.WriteLine("Your grade is E");
    Console.WriteLine("Your result for the exam is fail");
}


