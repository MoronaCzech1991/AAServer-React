using AAServer.Domain.Sys.Modules.Register.Enums;

namespace AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo.ShippingCompanyAddressDo
{
    public class ShippingCompanyAddress
    {
        public ShippingCompanyAddress()
        {
            ShippingCompanyFather = new ShippingCompany();
        }

        public int Id { get; set; }
        public int IdShippingCompany { get; set; }
        public EnumCountry CountryProvider { get; set; }
        public string ZipCode { get; set; }
        public string PublicPlace { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }

        public ShippingCompany ShippingCompanyFather { get; set; }
    }
}
