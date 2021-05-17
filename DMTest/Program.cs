using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using XXDM.MyDM;

namespace DMTest
{
    internal class Program
    {
        private static XDm dm = new XDm();
        private static Colors colors = new Colors();
        /// <summary>
        /// 游戏窗口句柄
        /// </summary>
        private static readonly int Hwnd = dm.FindWindow("", "");

        private static void Main(string[] args)
        {

            Console.ReadLine();
            //dm.ConLog(dm.Reg("", ""));//收费版  记得先注册
            dm.StartRunTime();

            //设置游戏分辨率
            dm.SetWindowSize(Hwnd, dm.GameWindowsSize[0], dm.GameWindowsSize[1]);

            var mainTask = Task.Run(() =>
              {
                  dm.ConLog("开始执行...");

                  RunCode();

                  dm.ConLog("执行完毕...");
                  dm.ShowRunTime();
              });

            Task.WaitAny(mainTask);
            dm.StopRunTime();
            Console.ReadLine();
        }

        /// <summary>
        /// 执行代码
        /// </summary>
        public static void RunCode()
        {
            dm.ConLog(Hwnd);
           
          
        
            if (dm.Find(colors.城镇_展开箭头按钮, true))
            {
                dm.delay(2000);
                dm.Find(colors.城镇_修行按钮, true);

                dm.delay(2000);

                dm.Find(colors.修行界面_关闭状态, true);

                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("no");
            }

       

        }
    }
}