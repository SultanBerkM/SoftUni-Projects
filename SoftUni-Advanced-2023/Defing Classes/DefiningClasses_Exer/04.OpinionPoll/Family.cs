using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OpinionPoll
{
    public class Family
    {
        private List<Person> listOfPerson;

        public List<Person> ListOfPerson
        {
            get { return listOfPerson; }
            set { listOfPerson = value; }
        }

        public Family()
        {
            this.ListOfPerson = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.ListOfPerson.Add(person);
        }

        public List<Person> GetOldestMembers()
        {
            return this.listOfPerson.Where(p => p.Age > 30).OrderBy(s => s.Name).ToList();
                                                
        }
    }
}
