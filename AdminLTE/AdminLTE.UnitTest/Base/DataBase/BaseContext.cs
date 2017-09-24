using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLTE.UnitTest.Base.DataBase
{
   public class BaseContext:DbContext
    {
        public IDbSet<UserEntity> Users { get; set; }

        public BaseContext() : base("adminLTE")
        {

        }

        public BaseContext(string connectionSringName) : base(connectionSringName)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            #region userConfig

            modelBuilder.Entity<UserEntity>().HasKey(p => p.UserId);
            modelBuilder.Entity<UserEntity>().ToTable("User");
            modelBuilder.Entity<UserEntity>()
                .Property(p => p.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<UserEntity>().Property(t => t.LoginName).HasMaxLength(50);
            modelBuilder.Entity<UserEntity>().Property(t => t.PassWord).HasMaxLength(50); 
            #endregion

        }
    }
}
