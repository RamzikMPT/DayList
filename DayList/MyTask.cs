using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayList
{
    public class MyTask
    {
        public int Id;
        
        public string Name;
        
        public string Description;
        
        public int Day;
        
        public int Month;
        
        public static List<MyTask> MyTasks = new List<MyTask>();
        
    }
}
