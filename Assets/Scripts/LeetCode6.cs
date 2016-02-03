using UnityEngine;
using System.Collections;

public class LeetCode6 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string str = Convert("aabb", 1);
//        Debug.Log("---" + Convert("aabb", 1));
//        Debug.Log("---" + Convert("aabb", 2));
//        Debug.Log("---" + Convert("PAYPALISHIRING", 2));
        Debug.Log("---" + Convert("PAYPALISHIRING", 3));
//        Debug.Log("---" + Convert("PAYPALISHIRING", 4));
//        Debug.Log("---" + Convert("PAYPALISHIRING", 5));
	}

    public string Convert(string s, int numRows) {
        int numbers_per_unit = numRows * 2 - 2;
        if (numbers_per_unit == 0)
        {
            return s;
        }
        int temp = s.Length % numbers_per_unit;
        int unit_count = temp == 0 ? s.Length / numbers_per_unit : s.Length / numbers_per_unit + 1;
        int length = unit_count * numbers_per_unit;
        char[] results = new char[length];
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            int index_in_unit = i % numbers_per_unit;
            int index_of_unit = i / numbers_per_unit;
            int number_in_line = numbers_per_unit == numRows ? 1 : (index_in_unit % (numRows - 1) == 0 ? 1 : 2);

            if (index_in_unit == 0)
            {
                results[index_of_unit] = c;
            }
            else
            {
                int line_in_unit = index_in_unit < numRows ? index_in_unit : numbers_per_unit - index_in_unit;
                int idx = unit_count + ((line_in_unit - 1) * unit_count * 2) + index_of_unit * number_in_line + index_in_unit/numRows;
                results[idx] = c;
            }
        }
        string result = new string(results);
        return result.Replace('\0'.ToString(), "");
    }
}
