using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProject
{
    public class User:Person
    {
        public User(string Name)
        {
            base.Name = Name;
            base.Type = "USER";
        }
    }
}
