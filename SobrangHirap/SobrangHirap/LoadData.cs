using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class LoadData
    {
        private string Fname;
        private string Mname;
        private string Lname;

        public string FirstName
        {
            get { return Fname; }
            set { Fname = value; }
        }
        public string MiddleName
        {
            get { return Mname; }
            set { Mname = value; }
        }

        public string LastName
        {
            get { return Lname; }
            set { Lname = value; }
        }

        public LoadData()
        {
            FirstName = " Fernan ";
            MiddleName = " Escopete";
            LastName = " Gambalan ";
        }

        public void DisplayInformation()
        {
            Console.WriteLine("First Name : {0}", FirstName);
            Console.WriteLine("Middle Name : {0}",MiddleName);
            Console.WriteLine("Last Name : {0}", LastName);
        }

    }
}
