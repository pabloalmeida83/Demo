using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class PlanningUnit
    {
        //Constructors
        public PlanningUnit()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Planning planning;
		private Unit unit;
		private PlanningStatus planningStatus;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public Planning Planning
        {
            get { return planning; }
            set { planning = value; }
        }

		public Unit Unit
        {
            get { return unit; }
            set { unit = value; }
        }

		public PlanningStatus PlanningStatus
        {
            get { return planningStatus; }
            set { planningStatus = value; }
        }


    }
}

