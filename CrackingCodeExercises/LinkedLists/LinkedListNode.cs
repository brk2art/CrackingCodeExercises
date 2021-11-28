using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeExercises.LinkedLists
{
    public class LinkedListNode
    {
        public LinkedListNode Next = null;
        public int Data;

        public LinkedListNode(int d)
        {
            Data = d;
        }

        public void AppendToTail(int d)
        {
            LinkedListNode end = new LinkedListNode(d);
            LinkedListNode n = this;
            while(n.Next != null)
            {
                n = n.Next;
            }
            n.Next = end;
        }
    }
}
