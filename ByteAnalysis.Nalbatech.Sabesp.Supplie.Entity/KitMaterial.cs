using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class KitMaterial
    {
        //Constructors
        public KitMaterial()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Kit kit;
		private Material material;


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

		public Material Material
        {
            get { return material; }
            set { material = value; }
        }


    }
}

