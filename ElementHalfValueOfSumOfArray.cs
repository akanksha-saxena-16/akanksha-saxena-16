// C# program to check if array has an
// element whose value is half of array
// sum.
using System;
using System.Collections.Generic;

class GFG
{

	// Function to check if answer exists
	static Boolean checkForElement(int []array, int n)
	{
		// Sum of all array elements
		// and storing in a hash table
		HashSet<int> s = new HashSet<int>();
		int sum = 0;
		for (int i = 0; i < n; i++)
		{
			sum += array[i];
			s.Add(array[i]);
		}
		
		// If sum/2 is present in hash table
		if (sum % 2 == 0 && s.Contains(sum / 2))
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	// Driver code
	public static void Main(String[] args)
	{
		int []array = {1, 2, 3};
		int n = array.Length;
		Console.WriteLine(checkForElement(array, n) ? "Yes" : "No");
	}
}

// This code is contributed by Princi Singh
