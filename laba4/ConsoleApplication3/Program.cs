using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = new Task(() =>
            {

            });

            var task2 = new Task(() =>
            {

            });

            task1.ContinueWith(task =>
            {
                task2.Start();
            });

            task1.Start();
        }
    }
}
