using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 万能播放器
{
    class Avi:Player
    {

        public Avi(string fileName):base(fileName) {
       

        } 
        public override void Play()
        {
            Console.WriteLine("播放avi,视频{0}",FileName);
        }
    }
}
