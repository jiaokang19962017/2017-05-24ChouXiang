using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 万能播放器
{
    abstract class Player
    {
        /// <summary>
        /// 文件名字
        /// </summary>
        protected string FileName;


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fileName">文件名</param>
        public Player(string fileName)
        {
            this.FileName = fileName;
        }
        

        /// <summary>
        /// 抽象方法
        /// </summary>
        public abstract void Play();
       
    }
}
