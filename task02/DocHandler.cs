using System;
using System.Reflection;

namespace task02
{
    public class DocHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod()?.ReflectedType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        }

        public override void Create()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod()?.ReflectedType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        }

        public override void Open()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod()?.ReflectedType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        }

        public override void Save()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod()?.ReflectedType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        }
    }
}
