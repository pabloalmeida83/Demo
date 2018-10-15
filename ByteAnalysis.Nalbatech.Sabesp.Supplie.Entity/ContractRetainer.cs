using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class ContractRetainer
    {
        //Constructors
        public ContractRetainer()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Contract contract;
		private string retainer;
		private DateTime retainerReceptDate;
		private DateTime retainerDerivelyDate;


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

		public string Retainer
        {
            get { return retainer; }
            set { retainer = value; }
        }

		public DateTime RetainerReceptDate
        {
            get { return retainerReceptDate; }
            set { retainerReceptDate = value; }
        }

		public DateTime RetainerDerivelyDate
        {
            get { return retainerDerivelyDate; }
            set { retainerDerivelyDate = value; }
        }


    }
}

