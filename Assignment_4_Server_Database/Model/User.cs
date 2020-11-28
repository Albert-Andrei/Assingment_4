namespace Assignment_4_Server_Database.Model
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        
        public int UserId { get; set; }
        public int SecurityLevel { get; set; }
    }
}