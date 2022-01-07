using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProject
{

    public class Group
    {
        public string Name { get; set; }
        public List<Person> members = new List<Person>();

        /// Cati membrii poate avea grupul
        private int observers = 2;
        private int users = 8;
        public void Add(Person person)
        {
            /// Vedem daca membrul mai apare in lista sau nu
            var add = true;
            for(int i = 0; i < members.Count; i++)
            {
                if (person.ID.Equals(members[i].ID))
                {
                    add = false;
                    break;
                }
            }

            if (add)
            {
                if (string.Equals(person.Type, "USER"))
                {
                    if (users > 0)
                    {
                        members.Add(person);
                        NotifyAll($"{person.Name} has added in the group.");
                        users--;
                    }
                    else
                        Console.WriteLine("Numarul de utilizatori ai grupului este epuizat ");

                }
                else
                if (string.Equals(person.Type, "OBSERVER"))
                {
                    if (observers > 0)
                    {
                        members.Add(person);
                        NotifyAll($"{person.Name} has added in the group.");
                        observers--;
                    }
                    else
                        Console.WriteLine("Numarul de observatori ai grupului este epuizat");
                }
            }
            else
                Console.WriteLine($"{person.Name} a mai fost adaugat o data!");
        }
        public void Remove(Person person)
        {
            for(int j = 0; j < members.Count; j++)
            {
                if (members[j].ID.Equals(person.ID))
                {
                    members.RemoveAt(j);
                    break;
                }
                
            }

            /// Crestem Limita membrilor grupului
            if (string.Equals(person.Type,"USER"))
                users++;
            else
                observers++;

            /// Notificare la toti 
            NotifyAll($"{person.Name} left the group.");
        }

        public void PrintList()
        {
            for(int i = 0; i < members.Count ; i++)
            {
                Console.WriteLine($"{i + 1}. {members[i].Name} with type : {members[i].Type}");
            }
        }

        public void NotifyAll(string message)
        {
            for(int i = 0; i < members.Count; i++)
            {
                members[i].Notify(message);
            }
        }

        public void Message(User user, string message)
        {
            NotifyAll(message);
        }
    }
}
