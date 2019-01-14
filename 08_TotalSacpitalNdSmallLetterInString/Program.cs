
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
//   
//  input       : Accept String. 
//  output      : To Find Capital And Small Alphabet How Many Time Occurese. 
//  Function Name:  CountLetter,count;
//  Creation Date:15 sept 2018 
//  Author: Amol Balasaheb Jore 
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

class CountLetter
{
    string str; 
    public CountLetter(string s)
    {
        str = s; 
    }
    public void Count()
    {
        int icap = 0, ismall = 0;
        for (int i = 0; i < str.Length; i++) 
        {
            if (str[i] >= 'A' && str[i] <= 'Z')
            {
                icap++;
            } 
            else 
            {
                ismall++; 
            }
        }
        Console.WriteLine("small letter count is: {0}", ismall);
        Console.WriteLine("Capital letter count is: {0}", icap);
    }
}
class main
{
    static void Main(string[] args) 
    {
        string str;
        Console.WriteLine("Enter a String");
        str = Console.ReadLine(); 
        CountLetter obj = new CountLetter(str);
        obj.Count();
    }
}
