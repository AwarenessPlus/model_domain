using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class User
    {
        [Key]
        private int _userID;

        [Required]
        private string _firstName;

        private string _secondName;

        [Required]
        private string _surname;

        private string _lastName;

        [Required]
        private DateTime _birthDate;

        public User()
        {

        }

        public int UserID { get => _userID; set => _userID = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string SecondName { get => _secondName; set => _secondName = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
    }
}
