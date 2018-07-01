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
        private string setup_name = "";
        private string teardown_name = "";

        private Type class_type = null;

        private MethodInfo class_method_exec = null;
        private MethodInfo class_method_setup = null;
        private MethodInfo class_method_teardown = null;

        private object class_obj = null;

        public Test( string _class_name, string _func_name, string _setup_name, string _teardown_name )
        {
            class_name = _class_name;
            func_name = _func_name;
            setup_name = _setup_name;
            teardown_name = _teardown_name;

            if (string.IsNullOrEmpty(class_name)) { return; }
            if (string.IsNullOrEmpty(func_name)) { return; }
            if (string.IsNullOrEmpty(setup_name)) { return; }
            if (string.IsNullOrEmpty(teardown_name)) { return; }

            class_type = Type.GetType(class_name);
            if (class_type == null) { return; }

            class_method_exec = class_type.GetMethod(func_name);
            class_method_setup = class_type.GetMethod(setup_name);
            class_method_teardown = class_type.GetMethod(teardown_name);

            class_obj = System.Activator.CreateInstance(class_type);
        }
        public bool SetUp()
        {
            return ExecMethod(class_obj, class_method_setup);
        }
        public bool Exec()
        {
            return ExecMethod(class_obj, class_method_exec);
        }
        public bool TearDown()
        {
            return ExecMethod(class_obj, class_method_teardown);
        }
        private bool ExecMethod(object classObj, MethodInfo classMethod )
        {
            if (classObj == null) { return false; }
            if (classMethod == null) { return false; }
            classMethod.Invoke(classObj, null);
            return true;
        }
    }
}
