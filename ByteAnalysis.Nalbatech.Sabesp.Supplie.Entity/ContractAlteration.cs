using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class ContractAlteration
    {
        //Constructors
        public ContractAlteration()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Contract contract;
		private DateTime requestDate;
		private string reason;
		private DateTime deadline;
		private decimal price;
		private string docPath;


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

		public DateTime RequestDate
        {
            get { return requestDate; }
            set { requestDate = value; }
        }

		public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

		public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

		public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

		public string DocPath
        {
            get { return docPath; }
            set { docPath = value; }
        }


    }
}

