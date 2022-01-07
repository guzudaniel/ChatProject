using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProject
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Guid ID = Guid.NewGuid();

       public void Notify(string message)
        {
            Console.WriteLine($"{Name} receive a message : {message}");
        }
    }
}
