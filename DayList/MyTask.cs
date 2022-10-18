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
        /// <summary>
        /// имя записки
        /// </summary>
        public string Name;
        /// <summary>
        /// Описание записи
        /// </summary>
        public string Description;
        /// <summary>
        /// День создания нашей задачи
        /// </summary>
        public int Day;
        /// <summary>
        /// Месяц задачи
        /// </summary>
        public int Month;
        /// <summary>
        /// Список задач
        /// </summary>
        public static List<MyTask> MyTasks = new List<MyTask>();
        /// <summary>
        /// Метод, расписывающий все задачи
        /// </summary>
       
    }
}
