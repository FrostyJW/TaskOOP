using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOOP.Interfaces;

namespace TaskOOP.Classes
{
    internal class Manager : Base,IManager
    {
        public Manager(String dateofrecruiment, String position, int id) 
            : base(dateofrecruiment, position, id)
        {

        }

        public Manager()
        {

        }
        public void ManagerMethod()
        {
            Console.WriteLine("Implemented IManager Interface!");   
        }

        public override void PromotionRequest()
        {
            Console.WriteLine("Manager requested Promotion...");
        }
    }
}
