using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GithubTest.Data
{
    class Stack
    {
        private int buf = -1;

        public Stack()
        {
            buf = -1;
        }

        public void Push( int value )
        {
            buf = value;
        }

        public int Front()
        {
            return buf;
        }

        public int Count()
        {
            return (buf < 0) ? 0 : 1;
        }

        public void testAddOneSetUp()
        {
            buf = -1;
        }
        public void testAddOneExec()
        {
            Push(2);
            Debug.Assert( Count() == 1 );
            Debug.Assert( Front() == 2 );
        }
        public void testAddOneTearDown()
        {
            buf = -1;
        }
    }
}
