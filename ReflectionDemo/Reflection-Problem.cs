using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Reflection_Problem
    {
        public static void DataInfo()
        {
          

                Type type = Type.GetType("Reflection_Demo.CustomerClass");
                Console.WriteLine(type.FullName);
                Console.WriteLine(type.Name);
                Console.WriteLine(type.Namespace);

                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo info in properties)
                {
                    Console.WriteLine(info.PropertyType.Name + " " + info.Name);
                }
                Console.WriteLine("\n");
                ConstructorInfo[] constructors = type.GetConstructors();
                foreach (ConstructorInfo constructor in constructors)
                {
                    Console.WriteLine(constructor.ToString());
                }
                Console.WriteLine("\n");

                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo info in methods)
                {
                    Console.WriteLine(info.ReturnType.Name + " " + info.Name);
                }
            
        }
    }
}
