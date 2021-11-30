namespace AAServer.Domain.Sys.Modules.Register.ClientDo.ClientAddressDo
{
    public class ClientAddress
    {
        public ClientAddress()
        {
            ClientFather = new Client();
        }

        public int Id { get; set; }
        public int IdClient { get; set; }
        public int ZipCode { get; set; }
        public string PublicPlace { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }

        public Client ClientFather { get; set; }
    }
}
