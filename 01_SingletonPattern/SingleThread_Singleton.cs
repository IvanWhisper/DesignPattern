using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingletonPattern
{
    /// <summary>
    /// 单线程Singleton实现
    /// </summary>
    public class SingleThread_Singleton
    {
        private static SingleThread_Singleton instance = null;
        private SingleThread_Singleton()
        {

        }
        public static SingleThread_Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingleThread_Singleton();
                }
                return instance;
            }
        }
    }
}
