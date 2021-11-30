using AAServer.Application.BaseViewAp;
using AAServer.Domain.UserDo;

namespace AAServer.Application.UserAp.View
{
    public class UserView
    {
        public int Id { get; set; }
        public int CodeTenant { get; set; }
        public string NameUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public EnumUser Level { get; set; }
        public User Viwer(UserView view)
        {
            return ViewBaseApp<User>.NewSelect(view);
        }
    }
}
