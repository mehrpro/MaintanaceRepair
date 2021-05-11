using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MR.Entity
{
    public class Group : BaseClass<int>
    {
        public Group()
        {
            Id = new int();
            Registered = DateTime.Now;
            IsActive = true;


            this.MachineryCodes = new HashSet<MachineryCode>();
        }


        [Required]
        [StringLength(250)]
        public string GroupName { get; set; }


        [StringLength(250)]
        public string Description { get; set; }

        public int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public Company Company { get; set; }



        public virtual ICollection<MachineryCode> MachineryCodes { get; set; }

    }
}