using AAServer.Application.UserAp.View;

namespace AAServer.Application.Prov.View
{
    public class ProvisitionView
    {
        public ProvisitionView()
        {
            UserView = new UserView();
        }

        public ProvisitionView(string name,
                               string email,
                               string password) 
        {
            UserView = new UserView();
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserView UserView { get; set; }
        public int CodeTenant { get; set; }
    }
}
