using UnityEngine;
using System.Collections;

public class LeetCode7 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Reverse(1234567899);
	}
	
    public int Reverse(int x) {
        int result = 0;
        while(x != 0) {
            if (result > 214748364 || result < -214748364) {
                return 0;
            }
            int number = x % 10;
            if (result == 214748364 && number > 7) {
                return 0;
            }
            else if (result == -214748364 && number < -8) {
                return 0;
            }
            result *= 10;
            result += number;
            x /= 10;
        }

        return result;
    }
}
