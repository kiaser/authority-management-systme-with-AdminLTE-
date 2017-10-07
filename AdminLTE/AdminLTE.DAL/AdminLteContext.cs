using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model.Entities;
using AdminLTE.Model.Map;

namespace AdminLTE.DAL
{
    public class AdminLteContext : DbContext
    {
        public AdminLteContext() : base("adminLTE")
        { }
        public AdminLteContext(string connectstringName) : base(connectstringName)
        { }
        public IDbSet<Model.Entities.User> Users { get; set; }
        public IDbSet<Model.Entities.Menu> Menus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
