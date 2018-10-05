using System;
using System.Collections.Generic;

namespace CodeProject.Sample.Domain
{
    public partial class Person : System.Object
    {

        private String firstname;
        
        public String FirstName
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }

        private String lastname;
        
        public String LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        private DateTime dateofbirth;
        
        public DateTime DateOfBirth
        {
            get { return this.dateofbirth; }
            set { this.dateofbirth = value; }
        }

        private Address address;
        
        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
    }
}


