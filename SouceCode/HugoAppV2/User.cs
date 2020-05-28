namespace HugoAppV2
{
    public class User
    {
        private string fullname { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private bool usertype { get; set; }

        public User(string fullname, string username, string password, bool usertype)
        {
            this.fullname = fullname;
            this.username = username;
            this.password = password;
            this.usertype = usertype;
        }

        
    }
}