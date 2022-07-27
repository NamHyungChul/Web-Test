using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessChk
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] NetClassClient = Process.GetProcessesByName("iexplore");
            Console.WriteLine("실행여부확인:" + NetClassClient.Length);
            System.Threading.Thread.Sleep(5000);
            if(NetClassClient.Length < 1)
            {
                Process.Start(@"C:\Program Files (x86)\Internet Explorer\iexplore.exe");
            }
            else
            {
                Console.WriteLine("프로그램 정상작동 확인");
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
