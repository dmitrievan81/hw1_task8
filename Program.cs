// The program calculates the parity of a numbers

using System;
class Program
{
    // function without any return type declaration  
    public int GetNumber(string VarName)
    {
        int res;
        string input;
        do
        {
            Console.WriteLine(String.Format("Enter number: {0} = ", VarName));
            input = Console.ReadLine();
        } while (int.TryParse(input, out res) == false);
        return res;
    }

    public static void Main(string[] args)
    {
        Program pr = new Program(); // Creating a class Object  
        Console.WriteLine("The program calculates the parity of a numbers.");

        string VarName_N = "N";
        int N = pr.GetNumber(VarName_N);
        
        for (int i = 1; i < N; i++)
        {
            if (i%2 == 0) 
                Console.WriteLine(String.Format("The value {0} is parity.", i));
        }
        
    }
}