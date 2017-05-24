using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 万能播放器
{
    class PlayTools
    {
        public bool IsPlayer(string fileName)
        {
            Player pl;
            Avi avi = new Avi(fileName);
            Mpeg mpeg = new Mpeg(fileName);
            Rmvb rmvb = new Rmvb(fileName);
            //去除视频文件名字的扩展名(格式名)
            string fileExtesion = fileName.Substring(fileName.IndexOf(".") + 1);

            if (!string.IsNullOrEmpty(fileExtesion))
            {
                switch (fileName.ToUpper())
                {
                    case "AVI":
                        //调用avi播放方法
                        pl = new Avi(fileName);
                       
                        break;
                    case "MPEG":
                        //调用mpeg播放方法
                        pl = new Mpeg(fileName);
                        break;
                    case "RMVB":
                        //调用rmvb播放方法
                        pl = new Rmvb(fileName);
                        break;
                    default:
                        return false;
                }
                pl.Play();
                return true;
            }
            
        return false;
            
    
        }
    }
}
