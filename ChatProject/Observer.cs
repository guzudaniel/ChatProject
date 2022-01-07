using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProject
{
    public class Observer:Person
    {
        public Observer(string Name)
        {
            base.Name = Name;
            base.Type = "OBSERVER";
        }
    }
}
