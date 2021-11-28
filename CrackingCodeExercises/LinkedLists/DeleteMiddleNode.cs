using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeExercises.LinkedLists
{
    class DeleteMiddleNode
    {
        bool deleteNode(LinkedListNode n)
        {
            if(n == null || n.Next == null)
            {
                return false;
            }
            LinkedListNode next = n.Next;
            n.Data = next.Data;
            n.Next = next.Next;
            return true;
        }
    }
}
