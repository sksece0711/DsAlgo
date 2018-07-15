using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAlgo.CSharp
{
    public class LinkedList_TraverseNodes : IRunner<LNode>
    {
        public void Run()
        {
            
        }

        public LNode Run(bool ret)
        {
            throw new NotImplementedException();
        }

        public string Run(object o1)
        {
            var linkedList = new LinkedList_AddNodes().Run(true);
            string result = "";
            LNode tmp = linkedList; // head
            while (tmp != null)
            {
                result += $"{tmp.data} --> ";
                tmp = tmp.next;
            }
            return result;
        }
    }
}
