using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class Ata
    {
        //Constructors
        public Ata()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private int idSGL;
		private AtaPosition ataPosition;
		private DateTime proposedDate;
		private DateTime startValidity;
		private DateTime endValidity;
		private int month;
		private string thing;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public int IdSGL
        {
            get { return idSGL; }
            set { idSGL = value; }
        }

		public AtaPosition AtaPosition
        {
            get { return ataPosition; }
            set { ataPosition = value; }
        }

		public DateTime ProposedDate
        {
            get { return proposedDate; }
            set { proposedDate = value; }
        }

		public DateTime StartValidity
        {
            get { return startValidity; }
            set { startValidity = value; }
        }

		public DateTime EndValidity
        {
            get { return endValidity; }
            set { endValidity = value; }
        }

		public int Month
        {
            get { return month; }
            set { month = value; }
        }

		public string Thing
        {
            get { return thing; }
            set { thing = value; }
        }


    }
}

