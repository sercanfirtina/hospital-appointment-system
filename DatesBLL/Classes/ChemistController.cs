using DatesBLL.Interfaces;
using DatesDAL.Interfaces;
using DatesDTOES.ChemistDTO;
using DatesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesBLL.Classes
{
    public class ChemistController : IChemistController
    {
        private IChemistManagement _IChemistManagement;

        public ChemistController(IChemistManagement IChemistManagement)
        {
            this._IChemistManagement = IChemistManagement;
        }

        public bool AddChemist(Chemist chemist)
        {
            bool result = this._IChemistManagement.AddChemist(chemist);

            return result;
        }

        public string FindEmail(string email)
        {
            return this._IChemistManagement.FindEmail(email);
        }

        public Chemist LoginChemist(string email, string pass)
        {
            Chemist chemist = this._IChemistManagement.LoginChemist(email, pass);

            return chemist;
        }

        public ChemistPatient FindDrugs(string prescriptionsCode)
        {
            ChemistPatient prescription = this._IChemistManagement.FindDrugs(prescriptionsCode);

            return prescription;
        }
    }
}
