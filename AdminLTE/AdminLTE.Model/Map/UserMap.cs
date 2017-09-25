using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model.Entities;

namespace AdminLTE.Model.Map
{
   public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User").HasKey(t => t.Id);
            Property(t => t.Id).HasColumnName("UserId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.LoginName).IsRequired().HasMaxLength(50);
            Property(t => t.PassWord).IsRequired().HasMaxLength(50);

        }
    }
}
