using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class optionalParameter
{
    //four ways that can be used to make parameters optional
    //1. use parameter arrays
    //2. use method overriding
    //3. specify parameters defaults
    //4. use OptionalAttribute that is present in System.Runtime.InteropServices namespace
    public static void Main()
    {
        AddNumbers(10, 20);
        AddNumbers(10, 20, new object[] {11, 22, 33});
        AddNumbers(10, 90, 89, 88, 90); // Calling the method with more than required parameters
    }
    //params should be at last
    public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfTheNumbers)
    {
        int result = firstNumber + secondNumber;
        foreach (int i in restOfTheNumbers)
        {
              result += i;
        }       

    Console.WriteLine("Total = " + result.ToString());
    }
}