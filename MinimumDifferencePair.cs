// C# program to find minimum
// difference between any pair
// in an unsorted array
using System;

class GFG
{
	// Returns minimum difference
	// between any pair
	static int findMinDiff(int[] arr,
						int n)
	{
		// Sort array in
		// non-decreasing order
		Array.Sort(arr);
		
		// Initialize difference
		// as infinite
		int diff = int.MaxValue;
		
		// Find the min diff by
		// comparing adjacent pairs
		// in sorted array
		for (int i = 0; i < n - 1; i++)
			if (arr[i + 1] - arr[i] < diff)
				diff = arr[i + 1] - arr[i];
		
		// Return min diff
		return diff;
	}

	// Driver Code
	public static void Main()
	{
		int []arr = new int[]{1, 5, 3, 19, 18, 25};
		Console.WriteLine("Minimum difference is " +
						findMinDiff(arr, arr.Length));
	
	}
}
