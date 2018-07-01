using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GithubTest
{
    class Program
    {
        private int testCount = 0;
        static void Main(string[] args)
        {
            Test.TestManager test = new Test.TestManager();
            test.Add("GithubTest.Program", "testMainExec", "testMainSetUp", "testMainTearDown");
            test.Run();
            test.Clean();
            return;
        }

        public void testMainSetUp()
        {
            testCount = 0;
        }
        public void testMainExec()
        {
            testCount = 1;
            Debug.Assert(testCount == 1);
        }
        public void testMainTearDown()
        {
            testCount = 0;
        }
    }
}
