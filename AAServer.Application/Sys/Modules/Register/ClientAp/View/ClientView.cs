using AAServer.Application.BaseViewAp;
using AAServer.Domain.Sys.Modules.Register.ClientDo;
using AAServer.Domain.Sys.Modules.Register.ClientDo.ClientAddressDo;
using System.Collections.Generic;

namespace AAServer.Application.Sys.Modules.Register.ClientAp.View
{
    public class ClientView
    {
        public ClientView()
        {
            Addresses = new List<ClientAddress>();
        }

        public bool IsActive { get; set; }

        // Common Data
        public int Id { get; set; }
        public EnumClient Type { get; set; }
        public int Active { get; set; }
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

        public Client Viwer(ClientView view)
        {
            return ViewBaseApp<Client>.NewSelect(view);
        }

        public ClientView ClientConverter(Client client)
        {
            return ViewBaseApp<ClientView>.NewSelect(client);
        }
    }
}
