using System;
class MainClass
{

    public static void Main(string[] arg)
    {
        MainClass mainClass = new MainClass();
        int sum = 0;
        //Console.WriteLine("Enter Two Numbers");
        //Console.WriteLine("Enter First Number");
        int number1=0
	//Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Second Number");
        int number2=0
	//Convert.ToInt32(Console.ReadLine());
        
        sum= mainClass.Add(number1, number2);

        Console.WriteLine("Sum of the Two Number is {0}",sum);
    }

     public  int Add(int num1,int num2)
    {
        int n1 = num1;
        int n2 = num2;
        int result = n1 + n2;
        return result;
    }
}