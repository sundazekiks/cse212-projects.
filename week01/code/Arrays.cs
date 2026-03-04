public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Process:
        // 1. Initialize a variable (List<double>) that will hold the multiple values
        // 2. Loop through the length provided then 

        // Initialize a list variable for storing our multiple values
        List<double> multiples = new List<double>();

        // Looping through the length
        for (int i = 1; i <= length; i++)
        {
            // Using the iterator multiply it to the number value
            multiples.Add(number * i);
        }
        // Since this function returns an array of doubles I converted my List to an Array 
        return multiples.ToArray();
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Process: Getting the last elements first and store it in a list variable, so no matter how much the amount is we're just gonna get the last elements of the list, store it in list variable and then remove them from the the original list then insert it into the start of the list

        // Get and Store the last elements from the data list in a variable
        List<int> lastElems = data.GetRange(data.Count - amount, amount);
        // Remove those last elements
        data.RemoveRange(data.Count - amount, amount);
        // then insert them into the start of the list
        data.InsertRange(0, lastElems);
    }
}
