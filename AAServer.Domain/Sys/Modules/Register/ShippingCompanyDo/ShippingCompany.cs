using AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo.ShippingCompanyAddressDo;
using AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo.ShippingCompanyContactDo;
using System.Collections.Generic;

namespace AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo
{
    // Transportadoras
    public class ShippingCompany
    {
        public ShippingCompany()
        {
            Addresses = new List<ShippingCompanyAddress>();
            Contacts = new List<ShippingCompanyContact>();
        }

        // Commom data
        public int Id { get; set; }
        public int CodeTenantShippingCompany { get; set; }
        public EnumShippingCompany Type { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }

        // Adtional information 
        public string Email { get; set; }
        public int DDDNumberPhoneComercial { get; set; }
        public int NumberPhoneComercial { get; set; }
        public int DDDCellPhone { get; set; }
        public int NumberCellPhone { get; set; }

        // Address
        public ICollection<ShippingCompanyAddress> Addresses { get; set; }

        // Contact
        public ICollection<ShippingCompanyContact> Contacts { get; set; }
    }
}
