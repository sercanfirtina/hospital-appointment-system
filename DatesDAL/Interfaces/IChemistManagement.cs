using DatesDTOES.ChemistDTO;
using DatesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesDAL.Interfaces
{
    public interface IChemistManagement
    {
        Chemist LoginChemist(string email, string pass);
        bool AddChemist(Chemist chemist);
        string FindEmail(string mail);
        ChemistPatient FindDrugs(string prescriptionsCode);

    }
}
