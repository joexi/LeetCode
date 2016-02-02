using UnityEngine;
using System.Collections;

public class LeetCode3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int l = LengthOfLongestSubstring ("1111222233456443444444444");
		Debug.Log (l);
	}
	
	public int LengthOfLongestSubstring(string s) {
		int length = 0;
		int max_length = 0;
		string subStr = "";
		for (int i = 0; i < s.Length; i++) {
			char c = s [i];
			int index = subStr.IndexOf (c);
			if (index >= 0) {
				length = subStr.Length;
				max_length = max_length > length ? max_length : length;

				subStr = subStr.Substring (index + 1);
				subStr += c.ToString ();
			}
			else {
				subStr += c.ToString ();
			}
		}
		max_length = max_length > subStr.Length ? max_length : subStr.Length;
		return max_length;
	}
}
