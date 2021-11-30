namespace AAServer.MVC.Autorizations
{
    public class CookieCreator
    {
        public CookieCreator()
        {
        }

        public string AutorizationLevelName { get; set; }
        public string NameIdentifier { get; set; }
        public string WebPage { get; set; }
        public bool RoleAdminLevel { get; set; }
        public bool RoleManagerLevel { get; set; }
        public bool RoleEmployeLevel { get; set; }
    }
}
