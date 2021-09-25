using System;
using System.Collections.Generic;

namespace Domain_Model_App
{
    public class Medic
    {
        private int _medicID;
        private string _firstName;
        private string _secondName;
        private string _surname;
        private string _lastName;
        private int _age;
        private int _userID;
        private int _authenticationID;
        private string _rotation;
        private int _semester;
        private ICollection<Procedure> _procedures;

        public int MedicID { get => _medicID; set => _medicID = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string SecondName { get => _secondName; set => _secondName = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }
        public int UserID { get => _userID; set => _userID = value; }
        public int AuthenticationID { get => _authenticationID; set => _authenticationID = value; }
        public string Rotation { get => _rotation; set => _rotation = value; }
        public int Semester { get => _semester; set => _semester = value; }
        public ICollection<Procedure> Procedures { get => _procedures; set => _procedures = value; }
    }
}
