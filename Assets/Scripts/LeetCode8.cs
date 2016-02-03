using UnityEngine;
using System.Collections;

public class LeetCode8 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log( MyAtoi("100"));
	}
	
    public int MyAtoi(string str) {
        int x = 1;
        int result = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char s = str[i];
            int ascii = (int)s;
            Debug.Log(ascii);
            if (i == 0 && ascii == 45)
            {
                x = -1;
            }
            else if (ascii >= 48 && ascii <= 57)
            {
                result *= 10;
                result += (ascii - 48);
            }
            else
            {
                return 0;
            }
        }
        return x * result;
    }
}
