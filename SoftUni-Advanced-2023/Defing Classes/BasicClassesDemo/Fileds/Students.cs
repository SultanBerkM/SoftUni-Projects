using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fileds
{
    class Students
    {
        private string name;
        private string lastName;
  
        public string FirstName
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string SecondName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FullName
        {
            get { return FirstName + SecondName; }

        }

    }
}
