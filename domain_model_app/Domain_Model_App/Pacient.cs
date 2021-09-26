using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Model_App
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

    public class Pacient
    {
        private int _pacientID;
        private User _pacientInfo;
        private BloodGroup? _bloodgroup;
        private Rh? _rh;
        private Sex? sex;

        public Pacient()
        {

        }

        public int PacientID { get => _pacientID; set => _pacientID = value; }
        public User PacientInfo { get => _pacientInfo; set => _pacientInfo = value; }
        public BloodGroup? Bloodgroup { get => _bloodgroup; set => _bloodgroup = value; }
        public Rh? Rh { get => _rh; set => _rh = value; }
        public Sex? Sex { get => sex; set => sex = value; }
    }
}
