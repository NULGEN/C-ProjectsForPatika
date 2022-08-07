using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingUygulamasi
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool voted { get; set; }

        public static List<User> UserList = new List<User>();
        public User()
        {

        }
        public User(string userName, string password, bool voted)
        {
            this.UserName = userName;
            this.Password = password;
            this.voted = voted;
            UserList.Add(this);

        }

        //public void UserList()
        //{
        //    Users.Add(new User("AliNaci", 123));
        //    Users.Add(new User("Keriman", 888));
        //    Users.Add(new User("Halitsu", 333));


        //}
        //if (userName!=UserName && password!=Password)
        //    {
        //        Console.WriteLine("Kayıtlı olmayan kullanıcı adı. Lütfen kayıt olunuz.");
        //        Console.Write("Kullanıcı Adını Giriniz: ");
        //        userName = Console.ReadLine();
        //        Console.Write("Şifre giriniz: ");
        //        password = int.Parse(Console.ReadLine());
        //Users.Add(new User(userName, password));
        //    }
    }
}

