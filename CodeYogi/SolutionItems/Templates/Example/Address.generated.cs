using System;
using System.Collections.Generic;

namespace CodeProject.Sample.Domain
{
    public partial class Address : System.Object
    {

        private String line1;
        
        public String Line1
        {
            get { return this.line1; }
            set { this.line1 = value; }
        }

        private String line2;
        
        public String Line2
        {
            get { return this.line2; }
            set { this.line2 = value; }
        }

        private String zip;
        
        public String ZIP
        {
            get { return this.zip; }
            set { this.zip = value; }
        }

        private String town;
        
        public String Town
        {
            get { return this.town; }
            set { this.town = value; }
        }

        private String country;
        
        public String Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
    }
}


