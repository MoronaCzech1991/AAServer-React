using AAServer.Domain.AccountDo;

namespace AAServer.Domain.UserDo
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set; }
        public int CodeTenantUser { get; set; }
        public string NameUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public EnumUser Level { get; set; }
        public bool IsActive { get; set; }

        public Account AccountUser { get; set; }
    }
}
