using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnesCentre_lab_2_2.Models
{
    public class User
    {
        public User()
        {
            Scedule = new List<Scedule>();
            Buy_subscription = new List<Buy_subscription>();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<Scedule> Scedule { get; set; }
        public virtual ICollection<Buy_subscription> Buy_subscription { get; set; }
    }
}
