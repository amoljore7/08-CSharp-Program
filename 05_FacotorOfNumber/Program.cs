//////////////////////////////////////////////////////////////////////////////////////////////////////////////
//		
//		Function Name	: Factor
//		Description		: It is used to Finading Factor Of Number.
//		Input			: int[IN]
//		Output			: int
//		Author Name		: Amol Balasaheb Jore
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

class Factor
{
    int iNum;
    public Factor(int x)
    {
        iNum = x;
    } 
    public void DisplayFact()
    {
        int i;
        for (i = 1; i <= iNum / 2; i++)
        {
            if (iNum % i == 0) 
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////
//		
//		Function Name	: main
//		Description		: Entry Point Function
//		Author Name		: Amol Balasaheb Jore
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
class main
{
    public static void Main(String[] args)
    {
        string userInput; 
        int intVal;
        Console.Write("Enter integer value: ");
        userInput = Console.ReadLine();
        /* Converts to integer type */
        intVal = Convert.ToInt32(userInput);
        Factor obj = new Factor(intVal);
        obj.DisplayFact();
    }
}