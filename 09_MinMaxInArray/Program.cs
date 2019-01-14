
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
//  
//  This code demonstrate the to find maximum number of that given number 
//  input       : Accept three Number. 
//  output      : To Find Maximum Number of that three Number. 
//  Function Name: Max,Min 
//  Creation Date:17 sept 2018 
//  Author: Amol Balasaheb Jore 
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

class ArrayMaxMin
{
    public static void Max(int[] arr)
    {
        int imax = arr[0]; 
        for (int i = 1; i < arr.Length; i++)
        { 
            if (arr[i] > imax)
            {
                imax = arr[i];
            }
        }
        Console.WriteLine("Maximum Element is:{0}", imax);
    }
    public static void Min(int[] arr) 
    {
        int imin = arr[0]; 
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < imin) 
            {
                imin = arr[i]; 
            }
        }
        Console.WriteLine("Minmum Element is:{0}", imin);
    }
    static void Main(string[] args)
    {
        string str; 
        int size;
        Console.WriteLine("Enter the Size of Array");
        str = Console.ReadLine(); 
        size = Convert.ToInt32(str);
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) 
        { 
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Max(arr);
        Min(arr);
    }
}