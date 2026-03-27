namespace AAServer.React.Controllers.HTTPResponse
{
    public class LoginResponseHTTP
    {
        public string response { get; private set; }

        public void LoginAccepted() 
        {
            response = "Login sucessefull";
        }

        public void LoginBadRequest()
        {
            response = "Login invalid";
        }
    }
}
