using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DsAlgo.CSharp;
using System.Diagnostics;

namespace DsAlgo.CSharp.Tests
{
    [TestClass]
    public class ProgramRunner
    {

        [TestMethod]
        public void LinkedList_AddNodes()
        {
            IRunner<LNode> addNodesInLinkedList = new LinkedList_AddNodes();
            var result = addNodesInLinkedList.Run(true);
            // Set a breakpoint here and inspect the result object.            
        }

        [TestMethod]
        public void LinkedList_TraverseNodes()
        {
            IRunner<LNode> traverseNodes = new LinkedList_TraverseNodes();
            string res = traverseNodes.Run(new object());
            Debug.WriteLine(res);
        }
    }
}
