using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOOP.Interfaces;

namespace TaskOOP.Classes
{
    internal class Assistant : Base,IAssistant
    {
        public Assistant(String dateofrecruiment, String position, int id) 
            : base(dateofrecruiment, position, id)
        {

        }
        public Assistant()
        {

        }
        public void AssistantMethod()
        {
            Console.WriteLine("Implemented IAssistant Interface!");
        }

        public override void PromotionRequest()
        {
            Console.WriteLine("Assistant requested Promo");
        }
    }
}
