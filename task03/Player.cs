using System;
using System.Reflection;

namespace task03
{
    public class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod()?.ReflectedType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        }

        public void Record()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod()?.ReflectedType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        }

        void IRecordable.Pause()
        {
            throw new NotImplementedException();
        }

        void IRecordable.Stop()
        {
            throw new NotImplementedException();
        }

        void IPlayable.Pause()
        {
            throw new NotImplementedException();
        }

        void IPlayable.Stop()
        {
            throw new NotImplementedException();
        }
    }
}