using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string IdCompany { get; set; }
        public string AccountType { get; set; }
        

        public User()
        {
            UserId = IdGenerate();
        }

        private string IdGenerate()
        {
            string character = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string UserID = "";
            Random random = new Random();

            while (UserID.Length < 36)
            {
                char c = (char)character[random.Next(character.Length)];

                UserID += c;

                if (UserID.Length == 8)
                    UserID += "-";
                else if (UserID.Replace("-", "").Length == 12)
                    UserID += "-";
                else if (UserID.Replace("-", "").Length == 16)
                    UserID += "-";
                else if (UserID.Replace("-", "").Length == 20)
                    UserID += "-";
            }

            return UserID;
        }
    }
}
