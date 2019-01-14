
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
//  
//  This code demonstrate the to find maximum number of that given number 
//  input       : Accept three Number. 
//  output      : To Find Maximum Number of that three Number. 
//  Function Name: Max,Min 
//  Creation Date:15 sept 2018 
//  Author: Amol Balasaheb Jore 
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

class Number
{
    int iNo1;
    int iNo2;
    int iNo3;
    public Number(int x, int y, int z)
    { 
        iNo1 = x; 
        iNo2 = y;
        iNo3 = z;
    }        
    public int Max() 
    {
        if ((iNo1 > iNo2) && (iNo1 > iNo2)) 
        {
            return iNo1;
        } 
        else if ((iNo2 > iNo1) && (iNo2 > iNo3))
        {
            return iNo2;
        } 
        else 
        {
            return iNo3; 
        }
    }
    public int Min()
    {
        if ((iNo1 < iNo2) && (iNo1 < iNo3)) 
        {
            return iNo1;
        }
        else if ((iNo2 < iNo1) && (iNo2 > iNo3)) 
        {
            return iNo2;
        }
        else
        {
            return iNo3; 
        }
    }
}
class main 
{
    static void Main(String[] args)
    {
        int iRet; 
        Number obj1 = new Number(10, 20, 30); 
        iRet = obj1.Max(); 
        Console.WriteLine("Maximum value is:{0}", iRet);
        iRet = obj1.Min();
        Console.WriteLine("Maximum value is:{0}", iRet);
    }
}