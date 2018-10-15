using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class KitUnit
    {
        //Constructors
        public KitUnit()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Kit kit;
		private Unit unit;
		private int coefficient;
		private int quantity;


        //Properties
		public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public Kit Kit
        {
            get { return kit; }
            set { kit = value; }
        }

		public Unit Unit
        {
            get { return unit; }
            set { unit = value; }
        }

		public int Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }
        }

		public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


    }
}

