using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class UnitMaterial
    {
        //Constructors
        public UnitMaterial()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Unit unit;
		private Material material;
		private StockType stockType;
		private UnitMaterialType unitMaterialType;
		private int analyticalConsumption;
		private int deadlineDelivery;
		private User user;
		private DateTime deletedDateTime;
		private int balance;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public Unit Unit
        {
            get { return unit; }
            set { unit = value; }
        }

		public Material Material
        {
            get { return material; }
            set { material = value; }
        }

		public StockType StockType
        {
            get { return stockType; }
            set { stockType = value; }
        }

		public UnitMaterialType UnitMaterialType
        {
            get { return unitMaterialType; }
            set { unitMaterialType = value; }
        }

		public int AnalyticalConsumption
        {
            get { return analyticalConsumption; }
            set { analyticalConsumption = value; }
        }

		public int DeadlineDelivery
        {
            get { return deadlineDelivery; }
            set { deadlineDelivery = value; }
        }

		public User User
        {
            get { return user; }
            set { user = value; }
        }

		public DateTime DeletedDateTime
        {
            get { return deletedDateTime; }
            set { deletedDateTime = value; }
        }

		public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }


    }
}

