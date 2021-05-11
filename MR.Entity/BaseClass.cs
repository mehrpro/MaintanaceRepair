using System;
using System.ComponentModel.DataAnnotations;

namespace MR.Entity
{
    public class BaseClass<T>
    {

        [Key]
        public T Id { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime Registered { get; set; }

        [Required]
        public bool IsDelete { get; set; }

    }
}