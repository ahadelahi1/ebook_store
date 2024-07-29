namespace Eproject_Online_Book_Store.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone_Num { get; set; }

        public string City { get; set; }

        public User(int id, string name, string email, string password, string phone_Num, string city)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Phone_Num = phone_Num;
            City = city;
        }
    }
}
