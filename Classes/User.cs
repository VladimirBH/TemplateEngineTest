namespace TemplateEngineTest.Classes
{
    public class User
    {
        public string UserLastName { get; set; }
        public string UserFirstName { get; set;}
        public string? UserMiddleName { get; set;}

        public User(string _userLastName, string _userFirstName)  
        {
            UserFirstName = _userFirstName;
            UserLastName = _userLastName;
        }

        public User(string _userLastName, string _userFirstName, string _userMiddleName)  
        {
            UserFirstName = _userFirstName;
            UserLastName = _userLastName;
            UserMiddleName = _userMiddleName;
        }
    }
}