
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
//  
//  This code demonstrate the to find Swaping number  
//  input       : Accept Two Number. 
//  output      : To Swapped Number. 
//  Function Name: SwapA,swapR 
//  Creation Date:17 sept 2018 
//  Author: Amol Balasaheb Jore 
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

class Swapping
{
    public unsafe void SwapA(int* x, int* y)
    {
    int tempswap = *x; 
        *x = *y; 
        *y = tempswap;
    }
    public void SwapR(ref int x, ref int y) 
    {
    int tempswap = x;
        x = y; 
        y = tempswap;
    }
    static unsafe void Main(String[] args)
    {
        string userInput; 
        int intVal1;
        int intVal2;

        Console.Write("Enter integer value1: ");
        userInput = Console.ReadLine();
        /* Converts to integer type */   
        intVal1 = Convert.ToInt32(userInput);
        Console.Write("Enter integer value2: "); 
        userInput = Console.ReadLine();   
        /* Converts to integer type */  
        intVal2 = Convert.ToInt32(userInput);

        SwapA(&intVal1, &intval2);
        SwapR(ref intVal1, ref intval2);
    }
}