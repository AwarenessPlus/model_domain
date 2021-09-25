using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Model_App
{
    public class Procedure
    {
        private int _procedureID;
        private string _procedureName;
        private string _patientStatus;
        private int _asa;
        private int _medicID;
        private int _pacientID;
        private Byte[] _videoRecord;

        public Procedure()
        {

        }

        public int ProcedureID { get => _procedureID; set => _procedureID = value; }
        public string ProcedureName { get => _procedureName; set => _procedureName = value; }
        public string PatientStatus { get => _patientStatus; set => _patientStatus = value; }
        public int Asa { get => _asa; set => _asa = value; }
        public int MedicID { get => _medicID; set => _medicID = value; }
        public int PacientID { get => _pacientID; set => _pacientID = value; }
        public byte[] VideoRecord { get => _videoRecord; set => _videoRecord = value; }
    }
}
