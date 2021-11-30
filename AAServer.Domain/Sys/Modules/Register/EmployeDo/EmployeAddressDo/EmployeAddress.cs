namespace AAServer.Domain.Sys.Modules.Register.EmployeDo.EmployeAddressDo
{
    public class EmployeAddress
    {
        public EmployeAddress()
        {
            EmployeFather = new Employe();    
        }

        public int Id { get; set; }
        public int IdEmploye { get; set; }
        public string ZipCode { get; set; }
        public string PublicPlace { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }     
        public string City { get; set; }

        public Employe EmployeFather { get; set; }
    }
}
