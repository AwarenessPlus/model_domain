using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public enum Sex
    {
        M, F, O
    }

    public enum BloodGroup
    {
        A, B, AB, O
    }

    public enum Rh
    {
        P, N, NULO
    }

    public class Patient
    {
        [Key]
        private int _patientID;

        [ForeignKey("User")]
        private int _userID;

        [Required]
        private int _documentID;

        private User _patientInfo;

        private BloodGroup? _bloodgroup;

        private Rh? _rh;

        private Sex? sex;

        public Patient()
        {

        }

        public int PatientID { get => _patientID; set => _patientID = value; }
        public User PatientInfo { get => _patientInfo; set => _patientInfo = value; }
        public BloodGroup? Bloodgroup { get => _bloodgroup; set => _bloodgroup = value; }
        public Rh? Rh { get => _rh; set => _rh = value; }
        public Sex? Sex { get => sex; set => sex = value; }
        public int UserID { get => _userID; set => _userID = value; }
        public int DocumentID { get => _documentID; set => _documentID = value; }
    }
}

