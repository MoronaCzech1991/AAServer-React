using AAServer.Domain.Sys.Modules.Register.ClientDo.ClientAddressDo;
using System.Collections.Generic;

namespace AAServer.Domain.Sys.Modules.Register.ClientDo
{
    public class Client
    {
        public Client()
        {
            Addresses = new List<ClientAddress>();
        }

        // Common data
        public int Id { get; set; }
        public int CodeTenantClient { get; set; }
        public EnumClient Type { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Phone 
        public int DDDNumberPhoneComercial { get; set; }
        public int NumberPhoneComercial { get; set; }
        public int DDDCellPhone { get; set; }
        public int NumberCellPhone { get; set; }
        public string Site { get; set; }
        public string Skipe { get; set; }

        // Address 
        public ICollection<ClientAddress> Addresses { get; set; }

        // Image
        public string ImagePath { get; set; }

        // Financial 
        public double LimitCredit { get; set; }
        public string Observation { get; set; }
    }
}
