using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAlgo.CSharp
{
    /// <summary>
    /// LinkedList node class
    /// </summary>
    public class LNode
    {
        public LNode(int data)
        {
            this.data = data;
        }
        public int data;
        public LNode next;
    }
}
