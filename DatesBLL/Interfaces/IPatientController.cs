using DatesDTOES;
using DatesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatesBLL.Interfaces
{
    public interface IPatientController
    {
        Patient LoginPatient(string email, string pass);
		bool AddPatient(Patient patient);
		string FindEmail(string email);
		void UpdatePatient(Patient updatePatient);
		List<Prescription> GetAllPrescription(int id);
		List<ShowPatientDate> GetAllDateByPatientID(int PatienId);
        List<City> GetAllCitis();
    }
}
