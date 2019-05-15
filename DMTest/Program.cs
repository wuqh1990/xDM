using System;
using System.Threading.Tasks;

using xDM;

using XXDM.Helper;

namespace DMTest
{
    internal class Program
    {
        private static xDm dm = new xDm();

        private static void Main(string[] args)
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
            //鼠标移动到 1,3 并点击鼠标左键
            dm.MoveTo(DmHelper.MouseEnum.鼠标左键, 1, 3);
            dm.ConLog("调用成功");
            //寻找微信窗口
            int i = dm.FindWindow("WeChatMainWndForPC", "");

            dm.ShowRunTime();

            dm.ConLog("WeChat窗口: " + i);
        }
    }
}