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
   public class MenuMap:EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            ToTable("Menu").HasKey(t => t.Id);
            Property(t => t.Id).HasColumnName("MenuId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Url).HasMaxLength(200);
        }
    }
}
