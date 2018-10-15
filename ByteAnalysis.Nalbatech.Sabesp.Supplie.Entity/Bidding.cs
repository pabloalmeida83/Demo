using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class Bidding
    {
        //Constructors
        public Bidding()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private DateTime createdDateTime;
		private int processNumber;
		private BiddingStatus biddingStatus;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public DateTime CreatedDateTime
        {
            get { return createdDateTime; }
            set { createdDateTime = value; }
        }

		public int ProcessNumber
        {
            get { return processNumber; }
            set { processNumber = value; }
        }

		public BiddingStatus BiddingStatus
        {
            get { return biddingStatus; }
            set { biddingStatus = value; }
        }


    }
}

