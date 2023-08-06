using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP.Classes
{
    abstract class Base
    {
        private String dateOfRecruiment;
        private String position;
        private int id;
        public String DateOfRecruiment { get { return dateOfRecruiment; } set { dateOfRecruiment = value; } }
        public String Position { get { return position; } set { position = value; } }
        public int Id { get { return id; } set { id = value; } }

        public abstract void PromotionRequest();

        public Base()
        {

        }

        public Base(string dateOfRecruiment, string position, int id)
        {
            DateOfRecruiment = dateOfRecruiment;
            Position = position;
            Id = id;
        }
    }
}
