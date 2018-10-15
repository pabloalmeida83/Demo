using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class CriticalityRating
    {
        //Constructors
        public CriticalityRating()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private string description;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public string Description
        {
            get { return description; }
            set { description = value; }
        }


    }
}

