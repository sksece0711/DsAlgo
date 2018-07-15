using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace DsAlgo.CSharp.Tests
{
    public class Base
    {
        public void DebugThis(Action action)
        {
            Debug.WriteLine("----------------------------------------------------------------");
            Debug.Indent();            
            action.Invoke();
            Debug.Unindent();
            Debug.WriteLine("----------------------------------------------------------------");
        }
    }
}
