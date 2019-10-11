using DatesDTOES.ChemistDTO;
using DatesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesBLL.Interfaces
{
    public interface IChemistController
    {
        Chemist LoginChemist(string email, string pass);
        bool AddChemist(Chemist chemist);
        string FindEmail(string email);
        ChemistPatient FindDrugs(string prescriptionsCode);
    }
}
