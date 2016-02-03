using UnityEngine;
using System.Collections;

public class LeetCode9 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(IsPalindrome(1));
        Debug.Log(IsPalindrome(11));
        Debug.Log(IsPalindrome(121));
        Debug.Log(IsPalindrome(1212311));
	}
	
    public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }
        int length = (int)System.Math.Log10(x) + 1;
        int[] results = new int[length];
        int index = 0; 
        while (x > 0)
        {
            int s = x % 10;
            x /= 10;
            results[index] = s;
            index++;
        }
        for (int i = 0; i < length / 2; i++)
        {
            if (results[i] != results[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
