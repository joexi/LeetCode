using UnityEngine;
using System.Collections;
/**
Given an array of integers, find two numbers such that they add up to a specific target number.

The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.

You may assume that each input would have exactly one solution.

Input: numbers={2, 7, 11, 15}, target=9
Output: index1=1, index2=2
*/

public class LeetCode1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] param = new int[]{ 2, 7, 11, 15 };
		int target = 9;
		int[] result = TwoSum (param, target);
		Debug.Log (result [0] + " " + result [1]);
	}
	
	public int[] TwoSum(int[] nums, int target) {
		int[] result = new int[2];

		for (int i = 0; i < nums.Length; i++) {
			for (int j = 0; j < nums.Length; j++) {
				int number_i = nums [i];
				int number_j = nums [j];
				if (i != j) {
					if (number_i + number_j == target) {
						result [0] = i < j ? i + 1 : j + 1;
						result [1] = i < j ? j + 1 : i + 1;
						return result;
					}
				}
			}
		}
		return result;
	}
}
