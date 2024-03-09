using System.Runtime.InteropServices;
using Tar2.BL;

namespace Tar3.BL
{
    public class User
    {

        string firstName;
        string lastName;
        string email;
        string password;
        bool isAdmin;
        bool isActive;

        static List<User> UserList = new List<User>();

      

        public User(string firstName, string lastName, string email, string password, bool isAdmin, bool isActive)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.IsAdmin = isAdmin;
            this.IsActive = isActive;   
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public bool IsActive { get => isActive; set => isActive = value; }

        public User()
        {

        }
    
    

       

        public int Insert()
        {
            DBservices dbs = new DBservices();
            return dbs.InsertUser(this);
        }

        public List<User> Read()
        {
            DBservices dbs = new DBservices();
            return dbs.ReadUsers();
        }

        public int Update()
        {
            DBservices dbs = new DBservices();
            return dbs.UpdateUser(this);
        }

       
    }
}
