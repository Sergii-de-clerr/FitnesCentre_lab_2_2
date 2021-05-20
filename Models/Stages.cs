using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnesCentre_lab_2_2.Models
{
    public class Stage
    {
        public int StageId { get; set; }
        public string Dayoftheweek { get; set; }
        public string StageDescription { get; set; }

        public virtual Scedule Scedule { get; set; }
    }
}
