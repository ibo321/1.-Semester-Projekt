using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt.Model
{
    class Staff
    {
        //public string AssistanChef { get; set; }
        //public string HeadChef { get; set; }
        //public string Cleaners { get; set; }
        //public int No { get; set; }
        public string Job { get; set; }
        public string Name { get; set; }
        //public static int Count { get; set; } = 1;

        public Staff(string job, string name)
        {
            //No = Count++;
            Job = job;
            Name = name;
        }

        //public Staff(string assistanChef, string headChef, string cleaners)
        //{
        //    AssistanChef = assistanChef;
        //    HeadChef = headChef;
        //    Cleaners = cleaners;
        //}

        public override string ToString()
        {
            return $"Job:\n{Job}\nName:\n{Name}";
        }
    }
}
