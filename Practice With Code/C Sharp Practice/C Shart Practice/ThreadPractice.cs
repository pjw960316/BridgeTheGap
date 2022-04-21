using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace C_Shart_Practice
{
    class ThreadPractice
    {
        static void Main()
        {
            ThreadPractice obj = new ThreadPractice();
            obj.GetMaxThread();
        }

        void GetMaxThread()
        {
            int worker_threads;
            int port_threads;
            ThreadPool.GetMaxThreads(out worker_threads, out port_threads); //using out to initialize
            Console.WriteLine(worker_threads + " " + port_threads);
        }        
    }
}
