using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer //Müşterinin özelliklerini tutmak içinde propertylerden classlardanda yararlanabiliyoruz...
    {
        public int Id { get; set; } //property

        private string _firstName; //field
        public string FirstName
        {
            get => "Mr." + _firstName;
            set => FirstName = value;
        }
        public string LastName { get; set; }
        public string City { get; set; }

        
        //public string FirstName; //field
    }
}
