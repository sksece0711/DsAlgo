namespace DsAlgo.CSharp
{
    public class LinkedList_AddNodes : IRunner<LNode>
    {
        LNode head = null;
        public void Run()
        {
            int[] values = { 1, 2, 3, 4, 5, 7, 3, 4, 5 };            
            foreach (var val in values)
                AddNode(ref head, val);
        }

        public LNode Run(bool ret)
        {
            Run();
            return head;
        }

        public string Run(object o1)
        {
            throw new System.NotImplementedException();
        }

        private void AddNode(ref LNode node, int val)
        {
            if (node == null)
                node = new LNode(val);
            else
                AddNode(ref node.next, val);
        }
    }
}
