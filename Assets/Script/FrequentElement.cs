using UnityEngine;
using System;
namespace FrequentElement
{
    public class FrequentElement : MonoBehaviour
    {
        public int[] array;
        void Start()
        {
            int maxOccurrences = foo(array);
            Debug.Log("maximum occurrences..."+ maxOccurrences.ToString());
        }
        int foo(int[] a)
        {
            Array.Sort(a);
            int max = 0, i = 0, element = 0;
            while( i < a.Length)
            {
                int temp = 0; 
                while( i+1 <a.Length && a[i+1] == a[i] )
                {
                    temp += 1;
                    i += 1;
                }

                if ( max < temp )
                {
                    max = temp;
                    element = a[i];
                }
                else if (max == temp )
                {
                    element = Math.Min(element, a[i]);
                }
                i++;
            }
            return element;
        }
    }
}