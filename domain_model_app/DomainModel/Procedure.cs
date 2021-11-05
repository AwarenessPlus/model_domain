using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Procedure
    {
        [Key]
        private int _procedureID;

        [Required]
        private string _procedureName;

        [Required]
        private string _patientStatus;

        [Required]
        private int _asa;

        [Required]
        private DateTime _procedureDate;

        [ForeignKey("Medic")]
        private int _medicID;

        [ForeignKey("Pacient")]
        private int _pacientID;

        private Patient _pacient;

        public Procedure()
        {

        }

        public int ProcedureID { get => _procedureID; set => _procedureID = value; }
        public string ProcedureName { get => _procedureName; set => _procedureName = value; }
        public string PatientStatus { get => _patientStatus; set => _patientStatus = value; }
        public int Asa { get => _asa; set => _asa = value; }
        public int MedicID { get => _medicID; set => _medicID = value; }
        public Patient Pacient { get => _pacient; set => _pacient = value; }
        public int PacientID { get => _pacientID; set => _pacientID = value; }
        public DateTime ProcedureDate { get => _procedureDate; set => _procedureDate = value; }
    }
}
