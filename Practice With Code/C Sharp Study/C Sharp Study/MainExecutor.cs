using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    class MainExecutor
    {
        ThreadPractice thread_practice;
        public static DelegateParameter delegate_parameter;
        private static MainExecutor main_executor;

        public static MainExecutor Instance() //Function
        {
            if(main_executor == null)
            {
                main_executor = new MainExecutor();
            }
            return main_executor;
        }

        private void Initialize()
        {
            thread_practice = new ThreadPractice();
            delegate_parameter = new DelegateParameter();            
        }

        static void Main()
        {
            MainExecutor.Instance();
            //main_executor.Initialize();      
        }
    }
}
