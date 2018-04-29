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
        public void Add( string _class_name, string _func_name )
        {
            list.Add(new Base.Test(_class_name, _func_name));
        }
        public void Run()
        {
            int success = 0;
            foreach( Base.Test test in list )
            {
                success += test.Exec() ? 1 : 0;
            }
            Console.WriteLine("total = " + list.Count() + "," + "success = " + success + "," + "failure = " + (list.Count() - success));
        }
    }
}
