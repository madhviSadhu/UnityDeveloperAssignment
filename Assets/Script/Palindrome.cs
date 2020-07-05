using System;
using UnityEngine;

namespace Palindrome
{
    public class Palindrome : MonoBehaviour
    {
        public string str;
        public int k;
        void Start()
        {
            if (k > str.Length || k == str.Length)
            {
                Debug.Log("InvalidInput....Palindrome");
            }
            else
            {
                if (IsPalindrome(str, k))
                {
                    Debug.Log("IsPalindrome = true");
                }
                else
                {
                    Debug.Log("IsPalindrome = false");
                }
            }
        }

        private bool IsPalindrome(string s , int i )
        {
            int length = s.Length;
            string r = Reverse(s);
            int p = PalindromeSequence(s.ToCharArray(), r.ToCharArray(), length, length);
            return (length - p <= i);
        }
        private string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private int PalindromeSequence(char[] s, char[] r, int m, int n)   
        {
            if (m == 0 || n == 0)
            {
              return 0;
            }

            if (s[m - 1] == r[n-1])
            {
              return 1 + PalindromeSequence(s, r, m - 1, n - 1);
            }
            else
            {
              return Math.Max(PalindromeSequence(s, r, m, n - 1), PalindromeSequence(s, r, m - 1, n));
            }
        }
    }
}