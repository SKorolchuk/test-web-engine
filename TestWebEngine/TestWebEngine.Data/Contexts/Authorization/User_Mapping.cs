using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebEngine.Data.Contexts.Authorization
{
    class User_Mapping : EntityTypeConfiguration<User>
    {
        public User_Mapping()
        {
            Property(x => x.Age).HasColumnType("int").IsOptional();
            Property(x => x.FirstName).HasMaxLength(25).IsOptional();
            Property(x => x.LastName).HasMaxLength(35).IsOptional();
            Property(x => x.Organization).HasMaxLength(50).IsOptional();
        }
    }
}
