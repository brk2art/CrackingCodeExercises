using System;

namespace CrackingCodeExercises.LinkedLists
{
    /*
     * Return Kth to Last: Implement an algorithm to find the kth to last element of a singly linked list.
     */
    class ReturnKthToLast
    {
        int printKthToLast(LinkedListNode head, int k)
        {
            if(head == null)
            {
                return 0;
            }
            int index = printKthToLast(head.Next, k) + 1;
            if(index == k)
            {
                Console.WriteLine(k + "th to last node is " + head.Data);
            }
            return index;
        }
    }
}
