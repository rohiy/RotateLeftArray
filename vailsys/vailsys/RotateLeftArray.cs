using System;

public class RotateArray
{
    public static void Main()
    {
        int[] testArray = { 1, 2, 3, 4, 5, 6, 7 };
        int[] result = RotateLeft(testArray, 2);

        // Print rotated array
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
    }

    public static int[] RotateLeft(int[] array, int positions)
    {
        // Check for negative rotate value
        if (positions < 0)
        {
            throw new ArgumentOutOfRangeException("positions", "Rotate value cannot be negative");
        }

        // Get array length
        int n = array.Length;

        // Handle case where rotate positions is greater than array length
        positions = positions % n;

        // Create result array
        int[] result = new int[n];

        // Loop through original array
        for (int i = 0; i < n; i++)
        {
            // Calculate new index accounting for rotation
            int newIndex = (i + n - positions) % n;
            // Assign value to new array
            result[newIndex] = array[i];
        }

        return result;
    }
}