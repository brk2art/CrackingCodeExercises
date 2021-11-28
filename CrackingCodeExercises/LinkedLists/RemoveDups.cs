using System.Collections.Generic;

namespace CrackingCodeExercises.LinkedLists
{
    class RemoveDups
    {
        void DeleteDubs(LinkedListNode n)
        {
            HashSet<int> set = new HashSet<int>();
            LinkedListNode previous = null;
            while(n != null)
            {
                if (set.Contains(n.Data))
                {
                    previous.Next = n.Next;
                }
                else
                {
                    set.Add(n.Data);
                    previous = n;
                }
                n = n.Next;
            }
        }
    }
}
