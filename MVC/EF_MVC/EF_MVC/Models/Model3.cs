using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EF_MVC.Models
{
    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<Student_Det> Student_Det { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Det>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Det>()
                .Property(e => e.Dept)
                .IsUnicode(false);
        }
    }
}
