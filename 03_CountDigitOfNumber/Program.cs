/*Write a program which accept number from user and count digits of that number  */

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//Class Name : Number
//Description : It is calculating number of digits of user enterd number
//Input : int[IN]
//Output : int[IN]
//Auther : Amol Jore. 12-09-2018
////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;

//class declaration
class Number
{
    int iNo; //characteristics

    int iCnt;

    public void Accept(int x) //constructor
    {
        iNo = x;
    }
    public void Count() //behaviour
    {
        if (iNo < 0)
        {
            iNo = -iNo;
        }

        while (iNo != 0)
        {
            iNo = iNo / 10;
            iCnt++;
        }
    }

    public void Display() //behaviour
    {
        Console.WriteLine("Number of digits are : {0}\n\n", iCnt);
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
        obj1.Count();

        //call the behavior to display max no
        obj1.Display();
    }
}