using AAServer.Domain.Sys.Modules.Register.Enums;

namespace AAServer.Domain.Sys.Modules.Register.ProviderDo.ProviderAddressDo
{
    public class ProviderAddress
    {
        public ProviderAddress()
        {
            ProviderFather = new Provider();
        }

        public int Id { get; set; }
        public int IdProvider { get; set; }
        public EnumCountry CountryProvider { get; set; }
        public int ZipCode { get; set; }
        public string Address { get; set; }
        public int NumberAddress { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Quarter { get; set; }
        public string Complement { get; set; }

        public Provider ProviderFather { get; set; }
    }
}
