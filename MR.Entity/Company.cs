using System;
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
        }

        [Required]
        [StringLength(250)]
        public string CompanyName { get; set; }
        [StringLength(250)]
        public string Description { get; set; }



    }
}