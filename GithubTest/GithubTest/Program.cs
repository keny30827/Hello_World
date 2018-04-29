using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.TestManager test = new Test.TestManager();
            test.Add("GithubTest.Program", "testMain");
            test.Run();
            return;
        }
        public void testMain()
        {
            Console.WriteLine("test");
        }
    }
}
