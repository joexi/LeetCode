using UnityEngine;
using System.Collections;

public class LeetCode4 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        double result = FindMedianSortedArrays(new int[]{ }, new int[]{ 2, 3, 4, 4 });
        Debug.LogError(result);
    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int sum = 0;
        int number_sum = nums1.Length + nums2.Length;
        int index1 = 0;
        int index2 = 0;
        double midian = 0;
        int[] numbers = new int[number_sum];
        for (int i = 0; i < number_sum; i++)
        {
            if (index1 >= nums1.Length)
            {
                numbers[i] = nums2[index2];
                index2++;
            }
            else if (index2 >= nums2.Length)
            {
                numbers[i] = nums1[index1];
                index1++;
            }
            else if (nums1[index1] < nums2[index2])
            {
                numbers[i] = nums1[index1];
                index1++;
            }
            else
            {
                numbers[i] = nums2[index2];
                index2++;
            } 

        }
        if (number_sum % 2 == 1)
        {
            midian = numbers[number_sum / 2];
        }
        else
        {
            midian = (double)(numbers[number_sum / 2] + numbers[(number_sum / 2) - 1]) / 2;
        }
        return midian; 
    }
}
