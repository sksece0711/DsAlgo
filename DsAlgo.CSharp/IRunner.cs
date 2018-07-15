using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAlgo.CSharp
{
    public interface IRunner<T> where T:class
    {
        void Run();
        T Run(bool ret);
        string Run(object o1);
    }
}
