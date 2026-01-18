using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    internal class Menu
    {
        private string[] tasks;
        private int quantityOfTasks;

        public Menu(string[] tasks)
        {
            this.tasks = new string[tasks.Length];

            for (int i = 0; i < tasks.Length; i++)
            {
                this.tasks[i] = $"{i+1}. " + tasks[i];
            }
            quantityOfTasks = tasks.Length;
        }

        public string[] Tasks
        {
            get { return tasks; }
        }

        public int QuantityOfTasks
        {
            get { return quantityOfTasks; }
        }

        public string[] GetTasks()
        {
            return tasks;
        }
        public int GetQuantityOfTasks()
        {
            return quantityOfTasks;
        }
    }
}
