using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 万能播放器
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayTools pt = new PlayTools();//实例化播放工具类
            bool result = pt.IsPlayer("123.avi");
            if (result == true)
            {
                Console.WriteLine("播放成功");
            }
            else
            {
                Console.WriteLine("播放失败");
            }
        }
    }
}
