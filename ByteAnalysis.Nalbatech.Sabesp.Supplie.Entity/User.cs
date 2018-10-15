using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class User
    {
        //Constructors
        public User()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Profile profile;
		private string name;
		private string password;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public Profile Profile
        {
            get { return profile; }
            set { profile = value; }
        }

		public string Name
        {
            get { return name; }
            set { name = value; }
        }

		public string Password
        {
            get { return password; }
            set { password = value; }
        }


    }
}

