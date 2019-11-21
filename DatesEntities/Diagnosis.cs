using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesEntities
{
     public class Diagnosis
    {
        public int ID { get; set; }
        public string DiagnosisName { get; set; }
        public string DiagnosisDescription { get; set; }

		public override string ToString()
		{
			return this.DiagnosisName;
		}
	}
}
