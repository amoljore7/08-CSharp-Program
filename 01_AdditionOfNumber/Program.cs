/*Write a program which accept 5 numbers from command line and perform addition of that numbers and display on console   */

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//Class Name : Number
//Description : It is calculating addition of user entered 5 numbers
//Input : int[IN],int[IN],int[IN],int[IN],int[IN]
//Output : int[IN]
//Auther : Amol Jore. 12-09-2018
////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;

//class declaration
class Number
{
    int iNo1; //characteristics
    int iNo2;
    int iNo3;
    int iNo4;
    int iNo5;
    int iResult;

    public void Accept(int A, int B, int C, int D, int E) //constructor
    {
        iNo1 = A;
        iNo2 = B;
        iNo3 = C;
        iNo4 = D;
        iNo5 = E;
    }
    public void Addition() //behaviour
    {
        iResult = iNo1 + iNo2 + iNo3 + iNo4 + iNo5;
    }

    public void Display() //behaviour
    {
        Console.WriteLine("Addition of 5 numbers is: {0}\n\n", iResult);
    }

}



/////////////////////////////////////////////////////////////////////////////////////////////////////////
//Class Name : Program
//Description : Entry point fuction
//Auther : Amol Jore. 12-09-2018
////////////////////////////////////////////////////////////////////////////////////////////////////////

class Program
{
    static void Main(string[] args)
    {
        //create object of Number class
        Number obj1 = new Number();

        int iNumber1, iNumber2, iNumber3, iNumber4, iNumber5;

        Console.WriteLine("Enter the Number1");
        iNumber1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Number2");
        iNumber2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Number3");
        iNumber3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Number4");
        iNumber4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Number5");
        iNumber5 = Convert.ToInt32(Console.ReadLine());

        //call the behaviour to set characteristics
        obj1.Accept(iNumber1, iNumber2, iNumber3, iNumber4, iNumber5);

        //call the behaviour to perform max operation
        obj1.Addition();

        //call the behavior to display max no
        obj1.Display();
    }
}