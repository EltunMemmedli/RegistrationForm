using Registration.Models;

namespace Registration.Repository
{
    public class UserRepo
    {
        public static List<User> Users = new List<User>() 
        {
            new User(){ Name = "Eltun", Surname = "Memmedli", Email = "eltun@gmail.com", Particibate = true},
            new User(){ Name = "Eltun", Surname = "Memmedli", Email = "eltun@gmail.com", Particibate = true},
            new User(){ Name = "Eltun", Surname = "Memmedli", Email = "eltun@gmail.com", Particibate = true},
            new User(){ Name = "Eltun", Surname = "Memmedli", Email = "eltun@gmail.com", Particibate = true},

        };

        public static List<User> GetUser() 
        {
            return Users; 
        }
        public static void Form(User user)
        {
            int newID = 1;
            while (Users.Any(u => u.Id == newID))
            {
                newID++;
            }

            if (user == null)
            {
                Console.WriteLine("Invalid user.");
                return;
            }

            user.Id = newID;
            Users.Add(user);
        }

    }
}
