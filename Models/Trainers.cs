using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnesCentre_lab_2_2.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public int TrainerCost { get; set; }
        public int PhoneNumber { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Scedule> Scedule { get; set; }
        public virtual ICollection<Discipline> Discipline { get; set; }
    }
}
