using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EF_MVC.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
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
