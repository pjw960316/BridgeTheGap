using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    class DelegateParameter
    {
        delegate void MyDelegate();
        MyDelegate obj = new MyDelegate(MainExecutor.delegate_parameter.Func);
                
        private void Func()
        {
            Console.WriteLine("hi");
        }
    }
}
