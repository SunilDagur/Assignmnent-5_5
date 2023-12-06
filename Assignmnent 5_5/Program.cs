using System;

class ExceptionHandlingDemo
{
    static void Main()
    {
        try
        {
           
            int[] numbers = { 1, 2, 3 };
            int indexOutOfRangeValue = numbers[5];
            
            string invalidNumberString = "abc";
            int parsedNumber = int.Parse(invalidNumberString); 
           
            throw new InvalidOperationException("This is an example of InvalidOperationException.");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException caught: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException caught: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"InvalidOperationException caught: {ex.Message}");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Unexpected exception caught: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("This block always executes, regardless of whether an exception occurred or not.");
        }

        Console.WriteLine("Program continues execution after the try-catch-finally block.");
    }
}
