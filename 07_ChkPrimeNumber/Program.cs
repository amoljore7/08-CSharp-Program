
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
//  
//  This code demonstrate the to find Prime number of that given number 
//  input       : Accept Any One Number. 
//  output      : To Find Prime Number of that three Number. 
//  Function Name: ChkPrime 
//  Creation Date:17 sept 2018 
//  Author: Amol Balasaheb Jore 
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
class Number
{
    int i;
    int iSum;

    public void chkPrime(int iNo)
    {
        for (i = 2; i <= iNo; i++)

            if ((iNo % i) == 0)
            {
                break;
            }

        if (i == iNo)
        {
            Console.WriteLine("\t\t {0} is Prime No\t", iNo);
        }
        else
        {
            Console.WriteLine("\t\t {0} is Not Prime No\t", iNo);
        }
    }
    public void chkPerfect(int iNo)
    {
        for (i = 1; i <= iNo / 2; i++)
        {

            if (iNo % i == 0)
                iSum = iSum + i;
        }
        if (iSum == iNo)
            Console.WriteLine("\t\tPerfect\n");
        else
            Console.WriteLine("\t\tNot Perfcet\n");
    }

}
class Program
{
    public static void Main(String[] args)
    {
        Number obj1 = new Number();
        Number obj2 = new Number();

        int iNo = 0;
        Console.WriteLine("Check Number Prime OR NOT :");
        iNo = Convert.ToInt32(Console.ReadLine());

        obj1.chkPrime(iNo);

        Console.WriteLine("Check Number Perfect OR NOT:");
        iNo = Convert.ToInt32(Console.ReadLine());

        obj2.chkPerfect(iNo);

    }
}