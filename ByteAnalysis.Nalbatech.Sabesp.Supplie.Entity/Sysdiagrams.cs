using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class Sysdiagrams
    {
        //Constructors
        public Sysdiagrams()
        {
            this.diagram_id = -1;

        }
    
        //Attributs
		private string name;
		private int principal_id;
		private int diagram_id;
		private int version;
		private byte[] definition;


        //Properties
		public string Name
        {
            get { return name; }
            set { name = value; }
        }

		public int Principal_id
        {
            get { return principal_id; }
            set { principal_id = value; }
        }

		public int Diagram_id
        {
            get { return diagram_id; }
            set { diagram_id = value; }
        }

		public int Version
        {
            get { return version; }
            set { version = value; }
        }

		public byte[] Definition
        {
            get { return definition; }
            set { definition = value; }
        }


    }
}

