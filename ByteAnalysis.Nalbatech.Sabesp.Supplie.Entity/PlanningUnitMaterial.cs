using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class PlanningUnitMaterial
    {
        //Constructors
        public PlanningUnitMaterial()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Planning planning;
		private Unit unit;
		private Material material;
		private int quantity;
		private User user;
		private DateTime createdDateTime;
		private string justification;


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

		public Material Material
        {
            get { return material; }
            set { material = value; }
        }

		public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

		public User User
        {
            get { return user; }
            set { user = value; }
        }

		public DateTime CreatedDateTime
        {
            get { return createdDateTime; }
            set { createdDateTime = value; }
        }

		public string Justification
        {
            get { return justification; }
            set { justification = value; }
        }


    }
}

