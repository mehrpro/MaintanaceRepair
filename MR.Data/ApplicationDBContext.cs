using System.Data.Entity;
using MR.Entity;

namespace MR.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("ConecctionStringDB")
        {

        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<MachineryCode> MachineryCodes { get; set; }


    }
}