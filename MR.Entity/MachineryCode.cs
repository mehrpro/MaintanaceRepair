using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MR.Entity
{
    public class MachineryCode : BaseClass<int>
    {
        public MachineryCode()
        {
            Id = new int();
            Registered = DateTime.Now;
            IsActive = true;
        }

        [Required]
        [StringLength(200)]
        public string Machinery { get; set; }

        [Required]
        public int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public Company Company { get; set; }

        [Required]
        public int GroupID { get; set; }
        [ForeignKey("GroupID")]
        public Group Group { get; set; }



        public int Number { get; set; }


        [StringLength(250)]
        public string Description { get; set; }




    }
}