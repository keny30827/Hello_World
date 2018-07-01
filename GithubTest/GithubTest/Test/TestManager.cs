using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubTest.Test
{
    class TestManager
    {
        private List<Base.Test> list = new List<Base.Test>();
        public TestManager()
        {
        }
        public void Add( string _class_name, string _func_name, string _setup_name, string _teardown_name)
        {
            list.Add(new Base.Test(_class_name, _func_name, _setup_name, _teardown_name));
        }
        public void Run()
        {
            int success = 0;
            foreach( Base.Test test in list )
            {
                test.SetUp();
                success += test.Exec() ? 1 : 0;
                test.TearDown();
            }
            Console.WriteLine("total = " + list.Count() + "," + "success = " + success + "," + "failure = " + (list.Count() - success));
        }
        public void Clean()
        {
            list.Clear();
        }
    }
}
