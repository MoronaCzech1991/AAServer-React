using AAServer.Domain.Sys.Modules.Register.EmployeDo.EmployeAddressDo;
using System;
using System.Collections.Generic;

namespace AAServer.Domain.Sys.Modules.Register.EmployeDo
{
    public class Employe
    {
        public Employe()
        {
            Addresses = new List<EmployeAddress>();
        }

        // Common data
        public int Id { get; set; }
        public int CodeTenatEmploye { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string EnglishCPF { get; set; }
        public string EnglishRG { get; set; }
        public DateTime DateBirth { get; set; }
        public EnumTypeEmploye Type { get; set; }
        public EnumSex Sex { get; set; }
        public string Email { get; set; }
        public double Commission { get; set; }
        public string Observation { get; set; }

        // Image
        public byte[] image { get; set; }

        // Contacts
        public string Phone { get; set; }
        public int DDDCellPhonePrimary { get; set; }
        public int NumberCellPhonePrimary { get; set; }
        public int DDDCellPhoneSecondary { get; set; }
        public int NumberCellPhoneSecondary { get; set; }
        public string Skipe { get; set; }

        // Address
        public ICollection<EmployeAddress> Addresses { get; set; }
    }
}
