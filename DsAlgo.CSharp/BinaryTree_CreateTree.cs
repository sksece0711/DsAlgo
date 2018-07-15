using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAlgo.CSharp
{
    public class BinaryTree_CreateTree : IRunner<BNode>
    {
        BNode root = null;
        public void Run()
        {
            int[] values = { 1, 6, 3, 4, 5, 20, 34, 40, 7 };
            foreach (int i in values)
                AddNode(ref root, i);
        }

        private void AddNode(ref BNode node, int val)
        {
            if (node == null)
                node = new BNode(val);
            else if (val < node.val)
                AddNode(ref node.left, val);
            else
                AddNode(ref node.right, val);
        }


        public BNode Run(bool ret)
        {

            return root;
        }

        public string Run(object o1)
        {
            throw new NotImplementedException();
        }
    }
}
