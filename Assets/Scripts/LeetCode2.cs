using UnityEngine;
using System.Collections;

//You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
//
//	Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//	Output: 7 -> 0 -> 8

public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int x) { val = x; }
}

public class LeetCode2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ListNode l11 = new ListNode (1);
		ListNode l12 = new ListNode (2);
		ListNode l13 = new ListNode (3);
		l11.next = l12;
		l12.next = l13;

		ListNode l21 = new ListNode (2);
		ListNode l22 = new ListNode (3);
		ListNode l23 = new ListNode (4);
		l21.next = l22;
		l22.next = l23;
		ListNode result = AddTwoNumbers (l11, l21);
		while (result != null) {
			Debug.Log (result.val);
			result = result.next;
		}
	}

	public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
		ListNode result = new ListNode (0);
		ListNode current = result;
		int temp = 0;
		while (true) {
			int sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + temp;
			current.val = sum % 10;
			temp = sum / 10;

			l1 = l1 == null ? l1 : l1.next;
			l2 = l2 == null ? l2 : l2.next;

			if (l1 == null && l2 == null && temp == 0) {
				break;
			}
			current.next = new ListNode (0);
			current = current.next;
		}
		return result;
	}
}
