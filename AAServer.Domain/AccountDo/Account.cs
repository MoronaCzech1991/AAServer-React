using AAServer.Domain.UserDo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AAServer.Domain.AccountDo
{
    public class Account
    {
        public Account()
        {
            Users = new List<User>();
        }

        [Key]
        public int Tenant { get; set; }
        public string Name { get; set; }
        public DateTime AccountDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public void ValidateNameLenght() 
        {
            if (Name.Length <= 0 || Name.Length > 30)
                throw new Exception(string.Format("O nome deve ter entre 1 e 30 caracteres"));
        } 
    }
}
