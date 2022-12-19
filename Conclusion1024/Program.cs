// See https://aka.ms/new-console-template for more information

/*
Input: nums = {1,3,5,6}, target = 5 => 2
Output: 2

Input: nums = {1,3,5,6}, target = 2
Output: 1
Example 3:

Input: nums = {1,3,5,6}, target = 7
Output: 4
 */

using Conclusion1024;

int[] arr1 = {2,3,5,7};
int[] arr2 = {1,7,9,11,13};
var merged = Exercises.Merge(arr1, arr2);

int[] array = { 1, 6, 3, 8, 3, 6, 4, 7 };
array = Exercises.Sort(array);
Console.WriteLine(string.Join(", ", array));