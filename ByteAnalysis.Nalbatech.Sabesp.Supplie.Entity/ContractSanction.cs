using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class ContractSanction
    {
        //Constructors
        public ContractSanction()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Contract contract;
		private DateTime createdDate;
		private decimal penalty;
		private DateTime notification;
		private string justification;
		private string finalDecision;
		private bool emailSended;
		private SanctionStatus sanctionStatus;


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

		public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

		public decimal Penalty
        {
            get { return penalty; }
            set { penalty = value; }
        }

		public DateTime Notification
        {
            get { return notification; }
            set { notification = value; }
        }

		public string Justification
        {
            get { return justification; }
            set { justification = value; }
        }

		public string FinalDecision
        {
            get { return finalDecision; }
            set { finalDecision = value; }
        }

		public bool EmailSended
        {
            get { return emailSended; }
            set { emailSended = value; }
        }

		public SanctionStatus SanctionStatus
        {
            get { return sanctionStatus; }
            set { sanctionStatus = value; }
        }


    }
}

