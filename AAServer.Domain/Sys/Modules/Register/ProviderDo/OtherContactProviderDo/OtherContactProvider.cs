namespace AAServer.Domain.Sys.Modules.Register.ProviderDo.OtherContactProviderDo
{
    public class OtherContactProvider
    {
        public OtherContactProvider()
        {
            ProviderFather = new Provider();
        }

        public int Id { get; set; }
        public int IdProvider { get; set; }
        public string PersonContact { get; set; }
        public string EmailContact { get; set; }
        public string ContactPhone { get; set; }
        public string CellPhone { get; set; }
        public string PositionCompany { get; set; }

        public Provider ProviderFather { get; set; }
    }
}
