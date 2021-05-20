using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnesCentre_lab_2_2.Models
{
    public class Subscription
    {
        public Subscription()
        {
            Buy_subscription = new List<Buy_subscription>();
        }
        public int SubscriptionId { get; set; }
        public int Costperyear { get; set; }
        public int Type { get; set; }
        public int Sale { get; set; }

        public virtual ICollection<Buy_subscription> Buy_subscription { get; set; }
    }
}
