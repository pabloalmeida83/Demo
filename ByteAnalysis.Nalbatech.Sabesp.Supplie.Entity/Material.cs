using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class Material
    {
        //Constructors
        public Material()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private string idSap;
		private string idAMB;
		private string description;
		private string alternativeSupplie;
		private string unitMeasurement;
		private int detent;
		private CriticalityRating criticalityRating;
		private int leadTime;
		private decimal unitPrice;
		private DateTime lastUpdate;
		private int criticalDeliveryDeadline;
		private int ataDeadline;
		private bool status;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public string IdSap
        {
            get { return idSap; }
            set { idSap = value; }
        }

		public string IdAMB
        {
            get { return idAMB; }
            set { idAMB = value; }
        }

		public string Description
        {
            get { return description; }
            set { description = value; }
        }

		public string AlternativeSupplie
        {
            get { return alternativeSupplie; }
            set { alternativeSupplie = value; }
        }

		public string UnitMeasurement
        {
            get { return unitMeasurement; }
            set { unitMeasurement = value; }
        }

		public int Detent
        {
            get { return detent; }
            set { detent = value; }
        }

		public CriticalityRating CriticalityRating
        {
            get { return criticalityRating; }
            set { criticalityRating = value; }
        }

		public int LeadTime
        {
            get { return leadTime; }
            set { leadTime = value; }
        }

		public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

		public DateTime LastUpdate
        {
            get { return lastUpdate; }
            set { lastUpdate = value; }
        }

		public int CriticalDeliveryDeadline
        {
            get { return criticalDeliveryDeadline; }
            set { criticalDeliveryDeadline = value; }
        }

		public int AtaDeadline
        {
            get { return ataDeadline; }
            set { ataDeadline = value; }
        }

		public bool Status
        {
            get { return status; }
            set { status = value; }
        }


    }
}

