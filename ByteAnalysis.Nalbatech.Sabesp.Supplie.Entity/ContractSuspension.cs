using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class ContractSuspension
    {
        //Constructors
        public ContractSuspension()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Contract contract;
		private int deadlineDays;
		private DateTime rescission;
		private string rescissionPath;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public Contract Contract
        {
            get { return contract; }
            set { contract = value; }
        }

		public int DeadlineDays
        {
            get { return deadlineDays; }
            set { deadlineDays = value; }
        }

		public DateTime Rescission
        {
            get { return rescission; }
            set { rescission = value; }
        }

		public string RescissionPath
        {
            get { return rescissionPath; }
            set { rescissionPath = value; }
        }


    }
}

