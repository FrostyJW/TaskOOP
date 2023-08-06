using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOOP.Interfaces;

namespace TaskOOP.Classes
{
    internal class Director : Base,IDirector
    {
        public Director(String dateofrecruiment, String position, int id) 
            :  base(dateofrecruiment, position, id)
        {

        }
        public Director()
        {

        }
        public void DirectorMethod()
        {
            Console.WriteLine("Implemented IDirector Interface!");
        }

        public override void PromotionRequest()
        {
            Console.WriteLine("Director requested Promotion...");
        }
    }
}
