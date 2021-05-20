using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnesCentre_lab_2_2.Models
{
    public class Scedule
    {
        public Scedule()
        {
            Stage = new List<Stage>();
        }
        public int SceduleId { get; set; }
        public string SceduleName { get; set; }

        public virtual User User { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual Discipline Discipline { get; set; }

        public virtual ICollection<Stage> Stage { get; set; }
    }
}
