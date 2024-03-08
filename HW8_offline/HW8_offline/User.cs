namespace HW8_offline
{
    public class User
    {
        public string Login { get; set; }

        public string Pass { get; set; }

        public User()
        {
        }

        public User(string login, string pass)
        {
            Login = login;
            Pass = pass;
        }
    }
}
