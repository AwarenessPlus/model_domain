using System;
using System.Collections.Generic;

namespace Domain_Model_App
{
    public class Medic
    {
        private int _medicID;
        private User _medicData;
        private Authentication _authenticationData;
        private string _rotation;
        private int _semester;
        private ICollection<Procedure> _procedures;

        public Medic()
        {

        }

        public int MedicID { get => _medicID; set => _medicID = value; }
        public User MedicData { get => _medicData; set => _medicData = value; }
        public Authentication AuthenticationData { get => _authenticationData; set => _authenticationData = value; }
        public string Rotation { get => _rotation; set => _rotation = value; }
        public int Semester { get => _semester; set => _semester = value; }
        public ICollection<Procedure> Procedures { get => _procedures; set => _procedures = value; }
       
    }
}
