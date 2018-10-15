using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteAnalysis.Nalbatech.Sabesp.Supplie.Entity
{
    public class Note
    {
        //Constructors
        public Note()
        {
            this.id = -1;

        }
    
        //Attributs
		private int id;
		private Contract contract;
		private DateTime recivedDate;
		private Unit unit;
		private User user;


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

		public DateTime RecivedDate
        {
            get { return recivedDate; }
            set { recivedDate = value; }
        }

		public Unit Unit
        {
            get { return unit; }
            set { unit = value; }
        }

		public User User
        {
            get { return user; }
            set { user = value; }
        }


    }
}

