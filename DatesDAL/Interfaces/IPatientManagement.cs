using DatesDTOES;
using DatesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DatesDAL.Interfaces
{
    public interface IPatientManagement
    {
        Patient LoginPatient(string email, string pass);
		bool AddPatient(Patient patient);
		string FindEmail(string mail);
        void UpdatePatient(Patient updatePatient);
        List<Prescription> GetAllPrescription(int id);
		List<ShowPatientDate> GetAllDateByPatientID(int PatienId);
        List<City> GetAllCitis();

    }
}
