using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 万能播放器
{
    class Rmvb:Player
    {

        public Rmvb(string fileName):base(fileName) {


        }
        public override void Play()
        {
            Console.WriteLine("播放rmvb:{0}",FileName);
        }
    }
}
