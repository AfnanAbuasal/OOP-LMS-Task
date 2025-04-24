using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Task
{
    abstract class AbstractPerson
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public AbstractPerson(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public abstract void DisplayInfo();

    }
}
