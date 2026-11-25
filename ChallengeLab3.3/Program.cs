/*
Given an array of integers nums and an integer target, 
 
return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Input: nums = [2,7,11,15], target = 9

Output: [0,1]

Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/

int[] nums = new int[]{2,7,11,15};
Console.Write("Enter the target number : \n");
int targetNum = int.Parse(Console.ReadLine());
int[] final = TwoIndicesToTarget(nums, targetNum);

if (final.Length == 0)
    Console.WriteLine($"No matches found.");
else    
    Console.WriteLine($"[{string.Join(",", final)}]");

int[] TwoIndicesToTarget(int[] nums, int target)
{
    for (int i = 0; i < nums.Length -1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if ((nums[i] + nums[j] == target))
            {
                return new[] { i, j };
            }
        }
    }
    return Array.Empty<int>();
}
