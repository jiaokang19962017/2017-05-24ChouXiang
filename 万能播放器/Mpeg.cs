using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 万能播放器
{
    class Mpeg:Player
    {

        /// <summary>
        /// Mpeg的构造函数:给父类的构造函数传递参数
        /// 给父类的文件名赋值
        /// </summary>
        /// <param name="fileName"></param>
        public Mpeg(string fileName): base(fileName)
        {

        }


        /// <summary>
        /// 重写抽象基类的播放方法
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("播放mpeg视频{0}",FileName);
        }
    }
}
