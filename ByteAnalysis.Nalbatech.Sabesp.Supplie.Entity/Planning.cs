using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class Planning
    {
        //Constructors
        public Planning()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private string description;
		private User user;
		private DateTime createdDateTime;
		private PlanningType planningType;


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

		public User User
        {
            get { return user; }
            set { user = value; }
        }

		public DateTime CreatedDateTime
        {
            get { return createdDateTime; }
            set { createdDateTime = value; }
        }

		public PlanningType PlanningType
        {
            get { return planningType; }
            set { planningType = value; }
        }


    }
}

