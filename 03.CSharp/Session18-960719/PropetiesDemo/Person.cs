using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropetiesDemo
{
    class Person
    {
        private string cellPhone;
        public string CellPhone
        {
            get {
                if (!this.cellPhone.Contains("Invalid"))
                    return "+98" + this.cellPhone.Substring(1);
                else
                    return this.cellPhone;
            }
            set
            {
                if (value.Length == 11 && value.Substring(0, 2) == "09")
                {
                    this.cellPhone = value;
                }
                else
                {
                    this.cellPhone = "Invalid Cell Phone";
                }

            }
        }

        //private string name;
        //public string Name {
        //    get
        //    {
        //        return this.name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        public string Name { get; set; }

        public int Age { get; set; }
        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

    }
}
