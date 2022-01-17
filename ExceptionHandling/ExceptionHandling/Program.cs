using System;


    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deviding the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " devided by " + numberTwo + " equals " + numberThree);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please dont devide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("end of try catch");
            Console.ReadLine();
        }
        
       }
    }

