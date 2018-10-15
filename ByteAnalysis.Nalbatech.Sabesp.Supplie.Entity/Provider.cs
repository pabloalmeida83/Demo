using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class Provider
    {
        //Constructors
        public Provider()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private string companyName;
		private Int64 identify;
		private Int64 phone;
		private string email;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

		public Int64 Identify
        {
            get { return identify; }
            set { identify = value; }
        }

		public Int64 Phone
        {
            get { return phone; }
            set { phone = value; }
        }

		public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}

