//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MR.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Machinery
    {
        public int MachineryID { get; set; }
        public string MachineryTitel { get; set; }
        public int EntitiesID_FK { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Entity Entity { get; set; }
    }
}
