using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnesCentre_lab_2_2.Models
{
    public class Discipline
    {
        public Discipline()
        {
            Scedule = new List<Scedule>();
        }
        public int DisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public string DisciplineDescription { get; set; }

        public virtual ICollection<Scedule> Scedule { get; set; }
    }
}
