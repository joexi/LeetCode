using UnityEngine;
using System.Collections;

public class LeetCode5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string result = LongestPalindrome("33");
        Debug.LogError(result);
	}
	
    public string LongestPalindrome(string s) {
        string max_length_str = "";
        int max_length = 0;

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            int length = 1;
            int scaned_length = 0;
            while (true)
            {
                int left_index = i - scaned_length;
                int right_index = i + scaned_length;
                if (left_index >= 0 && right_index < s.Length)
                {
                    if (s[left_index] == s[right_index])
                    {
                        scaned_length += 1;
                        continue;
                    }
                }
                int str_length = (scaned_length - 1) * 2 + length;
                if (str_length > max_length)
                {
                    max_length = str_length;
                    max_length_str = s.Substring(i - (scaned_length - 1), str_length);
                }
                break;
            }

            length = 2;
            scaned_length = 0;
            while (true)
            {
                int left_index = i - scaned_length;
                int right_index = i + 1 + scaned_length;
                if (left_index >= 0 && right_index < s.Length)
                {
                    if (s[left_index] == s[right_index])
                    {
                        scaned_length += 1;
                        continue;
                    }
                }
                int str_length = (scaned_length - 1) * 2 + length;
                if (str_length > max_length)
                {
                    max_length = str_length;
                    max_length_str = s.Substring(i - (scaned_length - 1), str_length);
                }
                break;
            }
        }
        return max_length_str;
    }
}
