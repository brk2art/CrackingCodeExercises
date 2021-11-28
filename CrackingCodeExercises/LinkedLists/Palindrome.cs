namespace CrackingCodeExercises.LinkedLists
{
    class Palindrome
    {
        bool isPalindrome(LinkedListNode head)
        {
            LinkedListNode reversed = reverseAndClone(head);
            return isEqual(head, reversed);
        }

        LinkedListNode reverseAndClone(LinkedListNode node)
        {
            LinkedListNode head = null;
            while(node != null)
            {
                LinkedListNode n = new LinkedListNode(node.Data);
                n.Next = head;
                head = n;
                node = node.Next;
            }
            return head;
        }

        bool isEqual(LinkedListNode one, LinkedListNode two)
        {
            while(one != null && two != null)
            {
                if(one.Data != two.Data)
                {
                    return false;
                }
                one = one.Next;
                two = two.Next;
            }
            return one == null && two == null;
        }
    }
}
