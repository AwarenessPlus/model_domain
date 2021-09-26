using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Model_App
{
    public class Authentication
    {
        private int _AuthenticationID;
        private string _userName;
        private string _password;

        public Authentication()
        {

        }

        public void EncryptPassword(String textPassword)
        {
            MD5CryptoServiceProvider x = new ();
            byte[] bs = Encoding.UTF8.GetBytes(textPassword);
            bs = x.ComputeHash(bs);
            StringBuilder s = new ();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String hash = s.ToString();
            this._password = hash;
        }

        public int AuthenticationID { get => _AuthenticationID; set => _AuthenticationID = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }



    }
}
