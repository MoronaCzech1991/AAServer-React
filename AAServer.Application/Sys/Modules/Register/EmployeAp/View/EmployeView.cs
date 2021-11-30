using AAServer.Application.BaseViewAp;
using AAServer.Domain.Sys.Modules.Register.EmployeDo;

namespace AAServer.Application.Sys.Modules.Register.EmployeAp.View
{
    public class EmployeView
    {
        public Employe Viwer(EmployeView view)
        {
            return ViewBaseApp<Employe>.NewSelect(view);
        }
    }
}
