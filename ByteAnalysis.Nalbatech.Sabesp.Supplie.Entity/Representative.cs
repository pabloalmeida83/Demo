using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class Representative
    {
        //Constructors
        public Representative()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Provider provider;
		private string name;
		private string email;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public Provider Provider
        {
            get { return provider; }
            set { provider = value; }
        }

		public string Name
        {
            get { return name; }
            set { name = value; }
        }

		public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}

