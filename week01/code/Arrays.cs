public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step-by-step Plan:
        // 1. Create a new array of type double with a size equal to 'length'.
        // 2. Loop through the array using an index from 0 to length - 1.
        // 3. For each index i, compute the value as (i + 1) * number and store it in the array.
        // 4. After the loop completes, return the array.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3 
    /// then the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step-by-step Plan:
        // 1. Identify how many elements from the end will be moved to the front. This is 'amount'.
        // 2. Use GetRange to slice the last 'amount' elements of the list.
        // 3. Use GetRange to slice the beginning part of the list (up to data.Count - amount).
        // 4. Clear the original list.
        // 5. Add the two parts in order: the last part first, then the beginning part.

        List<int> endSlice = data.GetRange(data.Count - amount, amount);
        List<int> startSlice = data.GetRange(0, data.Count - amount);

        data.Clear();
        data.AddRange(endSlice);
        data.AddRange(startSlice);

        
    }
}
