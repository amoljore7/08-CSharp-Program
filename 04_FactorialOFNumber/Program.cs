/*Write a program which accept number from user and display its factorial   */

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//Class Name : Number
//Description : It is calculating factorial of user enterd number
//Input : int[IN]
//Output : int[IN]
//Auther : Amol Jore. 12-09-2018
////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;

//class declaration
class Number
{
    int iNo; //characteristics
    int iFact = 1;
    int iCnt;

    public void Accept(int x) //constructor
    {
        iNo = x;
    }
    public void Factorial() //behaviour
    {
        for (iCnt = 1; iCnt <= iNo; iCnt++)
        {
            iFact = iFact * iCnt;
        }
    }

    public void Display() //behaviour
    {
        Console.WriteLine("Factorial of entered number is: {0}\n\n", iFact);
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

        int Number;

        Console.WriteLine("Enter the Number");
        Number = Convert.ToInt32(Console.ReadLine());


        //call the behaviour to set characteristics
        obj1.Accept(Number);

        //call the behaviour to perform max operation
        obj1.Factorial();

        //call the behavior to display max no
        obj1.Display();
    }
}