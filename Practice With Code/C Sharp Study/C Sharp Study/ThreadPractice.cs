using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;


namespace C_Sharp_Study
{    
    class ThreadPractice
    {
        void MakeThreadPool()
        {
            ThreadPractice obj = new ThreadPractice();
            obj.GetMaxThread();

            ThreadPool.QueueUserWorkItem(Repeat, 'a');
        }
        
        void GetMaxThread()
        {
            int worker_threads;
            int port_threads;
            ThreadPool.GetMaxThreads(out worker_threads, out port_threads); //using out to initialize
            Console.WriteLine(worker_threads + " " + port_threads);
        }
        
        static void Repeat(object word)
        {
            for(int i=0; i<100; i++)
            {
                Console.WriteLine(word + " " + i);
            }
        }
    }


}
