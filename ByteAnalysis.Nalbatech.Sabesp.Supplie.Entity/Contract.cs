using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class Contract
    {
        //Constructors
        public Contract()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private int contractNumber;
		private Resource resource;
		private string attendedUnit;
		private int regPrice;
		private int idprovider;
		private DateTime deadline;
		private ContractStatus contractStatus;
		private int purchaseOrder;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public int ContractNumber
        {
            get { return contractNumber; }
            set { contractNumber = value; }
        }

		public Resource Resource
        {
            get { return resource; }
            set { resource = value; }
        }

		public string AttendedUnit
        {
            get { return attendedUnit; }
            set { attendedUnit = value; }
        }

		public int RegPrice
        {
            get { return regPrice; }
            set { regPrice = value; }
        }

		public int Idprovider
        {
            get { return idprovider; }
            set { idprovider = value; }
        }

		public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

		public ContractStatus ContractStatus
        {
            get { return contractStatus; }
            set { contractStatus = value; }
        }

		public int PurchaseOrder
        {
            get { return purchaseOrder; }
            set { purchaseOrder = value; }
        }


    }
}

