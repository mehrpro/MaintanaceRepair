

using System;
using System.ComponentModel.DataAnnotations;

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


        [StringLength(200)]
        public string Machinery { get; set; }
        

        public int CompanyID { get; set; }
        public int GroupID { get; set; }
        public int Number { get; set; }



    }
}