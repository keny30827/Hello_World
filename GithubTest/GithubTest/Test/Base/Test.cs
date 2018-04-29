using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace GithubTest.Test.Base
{
    class Test
    {
        private string class_name = "";
        private string func_name = "";
        public Test( string _class_name, string _func_name )
        {
            class_name = _class_name;
            func_name = _func_name;
        }
        public bool Exec()
        {
            if( string.IsNullOrEmpty(class_name)) { return false; }
            if (string.IsNullOrEmpty(func_name)) { return false; }
            Type type = Type.GetType(class_name);
            if (type == null) { return false; }
            object obj = System.Activator.CreateInstance(type);
            if (obj == null) { return false; }
            MethodInfo info = type.GetMethod( func_name );
            if (info == null) { return false; }
            info.Invoke(obj, null);
            return true;
        }
    }
}
