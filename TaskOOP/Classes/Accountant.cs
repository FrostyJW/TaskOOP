using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOOP.Interfaces;

namespace TaskOOP.Classes
{
    internal class Accountant : Base,IAccountant
    {
        public Accountant(String dateofrecruiment,String position, int id) 
            : base (dateofrecruiment, position, id)
        {

        }
        public Accountant()
        {

        }

        public void AccountantMethod()
        {
            Console.WriteLine("Implemented IAccountant Interface!");
        }

        public override void PromotionRequest()
        {
            Console.WriteLine("");
        }
    }
}
