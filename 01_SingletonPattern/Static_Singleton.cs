using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingletonPattern
{
    /// <summary>
    /// 静态Singleton实现
    /// </summary>
    public class Static_Singleton
    {
        public static readonly Static_Singleton instance = new Static_Singleton();
        private Static_Singleton() { }
        /* 等同于
           public static readonly Static_Singleton instance;
           static Static_Singleton()
           {
                instance = new Static_Singleton();
           }
           private Static_Singleton() { }
         */
    }
}
