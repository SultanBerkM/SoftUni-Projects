using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OldestFamilyMember
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

        public Person GetOldestMemebr()
        {
            return this.listOfPerson
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();
        }
    }
}
