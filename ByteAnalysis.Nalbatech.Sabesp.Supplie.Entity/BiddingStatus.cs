using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class BiddingStatus
    {
        //Constructors
        public BiddingStatus()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private string name;
		private string description;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public string Name
        {
            get { return name; }
            set { name = value; }
        }

		public string Description
        {
            get { return description; }
            set { description = value; }
        }


    }
}

