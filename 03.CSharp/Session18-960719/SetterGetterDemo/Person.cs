using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetterGetterDemo
{
    class Person
    {
        private string name;
        private string cellPhone;
        public void SetCellPhone(string _cellPhone)
        {
            if (_cellPhone.Length == 11 && _cellPhone.Substring(0, 2) == "09")
            {
                this.cellPhone = _cellPhone;
            }
            else
            {
                this.cellPhone = "Invalid Cell Phone";
            }
        }
        public string GetCellPhone()
        {
            if (!this.cellPhone.Contains("Invalid"))
                return "+98" + this.cellPhone.Substring(1);
            else
                return this.cellPhone;
        }

        public void SetName(string _name)
        {
            this.name = _name;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
