using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace pw7
{
    public class Optinosi
    {
        public static void Outputi()
        {
            DriveInfo c = DriveInfo.GetDrives()[0];
            Console.WriteLine(c);
        }
    }
}