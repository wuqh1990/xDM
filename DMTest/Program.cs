using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDM;

namespace DMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            xDm dm = new xDm();

            dm.ConLog(dm.Reg("注册码", ""));

            dm.StartTime();

            dm.MoveTo(xDm.MouseEnum.鼠标左键, 1, 3);
            dm.ConLog("调用成功");

            int i = dm.FindWindow("WeChatMainWndForPC", "");

            dm.ShowTime();

            dm.ConLog(i);

            Console.ReadLine();
        }
    }
}
