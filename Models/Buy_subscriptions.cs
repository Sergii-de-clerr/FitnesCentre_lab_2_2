using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnesCentre_lab_2_2.Models
{
    public class Buy_subscription
    {
        public int BuysubscriptionId { get; set; }
        public int BuysubscriptionCost { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}
