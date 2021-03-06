using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MR.Entity
{
    /// <summary>
    /// شرکت ها و گروه های تولیدی
    /// </summary>
    public class Company : BaseClass<int>
    {
        public Company()
        {
            Id = new int();
            Registered = DateTime.Now;
            IsActive = true;

            this.Groups = new HashSet<Group>();
            this.MachineryCodes = new HashSet<MachineryCode>();
        }

        [Required]
        [StringLength(250)]
        public string CompanyName { get; set; }
        [StringLength(250)]
        public string Description { get; set; }


        public virtual ICollection<MachineryCode> MachineryCodes { get; set; }
        public virtual ICollection<Group> Groups { get; set; }



    }
}