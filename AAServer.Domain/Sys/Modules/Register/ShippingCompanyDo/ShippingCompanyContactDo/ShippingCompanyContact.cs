namespace AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo.ShippingCompanyContactDo
{
    public class ShippingCompanyContact
    {
        public ShippingCompanyContact()
        {
            ShippingCompanyFather = new ShippingCompany();
        }

        public int Id { get; set; }
        public int IdShippingCompany { get; set; }
        public string PersonContact { get; set; }
        public string EmailContact { get; set; }
        public string ContactPhone { get; set; }
        public string CellPhone { get; set; }
        public string PositionCompany { get; set; }

        public ShippingCompany ShippingCompanyFather { get; set; }
    }
}
