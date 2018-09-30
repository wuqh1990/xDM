using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xDM;
using XXDM.Helper;
using static XXDM.Helper.DmHelper;

namespace DMTest
{
    class Program
    {
        private static IxDm dm = new xDm();

        static void Main(string[] args)
        {
            dm.ConLog(dm.Reg("自己的注册码", ""));

            dm.StartRunTime();

            Task.Run(() =>
            {
                dm.ConLog("开始执行...");
                RunCode();
                dm.ConLog("执行完毕...");
                dm.ShowRunTime();
            });


            Console.ReadLine();
            dm.StopRunTime();
        }


        /// <summary>
        /// 执行代码
        /// </summary>
        public static void RunCode()
        {
            dm.MoveTo(DmHelper.MouseEnum.鼠标左键, 1, 3);
            dm.ConLog("调用成功");

            int i = dm.FindWindow("WeChatMainWndForPC", "");

            dm.ShowRunTime();

            dm.ConLog(i);
        }




    }
}
