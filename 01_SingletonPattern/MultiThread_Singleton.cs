using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingletonPattern
{
    /// <summary>
    /// 多线程Singleton实现
    /// </summary>
    public class MultiThread_Singleton
    {
        /*
        此程序对多线程是安全的，使用了一个辅助对象lockHelper，
        保证只有一个线程创建实例（如果instance为空，保证只有一个线程
        instance = new MultiThread_Singleton();创建唯一的一个实例）。
        （Double Check)        请注意一个关键字volatile，
        如果去掉这个关键字，还是有可能发生线程不是安全的。
        volatile 保证严格意义的多线程编译器在代码编译时对指令不进行微调。
         */
        private static volatile MultiThread_Singleton instance = null;
        private static object lockHelper = new object();
        private MultiThread_Singleton() { }
        public static MultiThread_Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new MultiThread_Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
