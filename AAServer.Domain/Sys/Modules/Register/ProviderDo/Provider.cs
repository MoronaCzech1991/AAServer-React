using AAServer.Domain.Sys.Modules.Register.ProviderDo.OtherContactProviderDo;
using AAServer.Domain.Sys.Modules.Register.ProviderDo.ProviderAddressDo;
using System.Collections.Generic;

namespace AAServer.Domain.Sys.Modules.Register.ProviderDo
{
    public class Provider
    {
        public Provider()
        {
            Addresses = new List<ProviderAddress>();
            OtherContacts = new List<OtherContactProvider>();
        }

        // Common data
        public int Id { get; set; }
        public int CodeTenatProvider { get; set; }
        public bool IsActive { get; set; }
        public EnumProvider Type { get; set; }
        public string EnglishCNPJ { get; set; }
        public string FantasyName { get; set; }
        public string Name { get; set; }
        public string CodeCadaster { get; set; }

        // Adtional information 
        public string Email { get; set; }
        public int DDDNumberPhoneComercial { get; set; }
        public int NumberPhoneComercial { get; set; }
        public int DDDCellPhone { get; set; }
        public int NumberCellPhone { get; set; }

        // Address 
        public ICollection<ProviderAddress> Addresses { get; set; }

        //  Others contacts
        public ICollection<OtherContactProvider> OtherContacts { get; set; }

        // Observations 
        public string Observations { get; set; }
    }
}
