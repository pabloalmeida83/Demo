using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class PlanningMaterial
    {
        //Constructors
        public PlanningMaterial()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Planning planning;
		private Material material;
		private decimal price;
		private int sugestion;


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

		public Material Material
        {
            get { return material; }
            set { material = value; }
        }

		public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

		public int Sugestion
        {
            get { return sugestion; }
            set { sugestion = value; }
        }


    }
}

