using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder instance;
            Console.WriteLine("Please Enter House No:");
            string No = Console.ReadLine();
            string houseType = ConfigurationManager.AppSettings["No" + No];//ConfigurationSettings.AppSettings["No" + No];
            instance = (Builder)Assembly.Load(" _03_Builder").CreateInstance(" _03_Builder." + houseType);
            director.Construct(instance);
            House house = instance.GetHouse();
            house.Show();
            Console.ReadLine();
        }
    }
    public abstract class Builder
    {
        public abstract void BuildDoor();
        public abstract void BuildWall();

        public abstract House GetHouse();
    }
    public class House
    {
        Builder bu;
        public void ChineseBuilder()
        {
            bu = new ChineseBuilder();
        }
        public void RomanBuilder()
        {
            bu = new RomanBuilder();
        }

        public void Show()
        {
            Console.WriteLine("building");
        }
    }

    public class ChineseBuilder : Builder
    {
        private House ChineseHouse = new House();
        public override void BuildDoor()
        {
            Console.WriteLine("this Door 's style of Chinese");
        }
        public override void BuildWall()
        {
            Console.WriteLine("this Wall 's style of Chinese");
        }
        public override House GetHouse()
        {
            return ChineseHouse;
        }
    }
    public class RomanBuilder : Builder
    {
        private House RomanHouse = new House();
        public override void BuildDoor()
        {
            Console.WriteLine("this Door 's style of Roman");
        }
        public override void BuildWall()
        {
            Console.WriteLine("this Wall 's style of Roman");
        }
        public override House GetHouse()
        {
            return RomanHouse;
        }
    }

    /// <summary>
    /// 这一部分是 组合到一起的算法（相对稳定）
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildWall();
            builder.BuildDoor();
        }
    }
}
