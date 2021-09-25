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
        private string _firstName;
        private string _secondName;
        private string _surname;
        private string _lastName;
        private int _age;
        private int _userID;
        private BloodGroup? _bloodgroup;
        private Rh? _rh;
        private Sex? sex;

        public int PacientID { get => _pacientID; set => _pacientID = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string SecondName { get => _secondName; set => _secondName = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }
        public int UserID { get => _userID; set => _userID = value; }
        public BloodGroup? Bloodgroup { get => _bloodgroup; set => _bloodgroup = value; }
        public Rh? Rh { get => _rh; set => _rh = value; }
        public Sex? Sex { get => sex; set => sex = value; }
    }
}
