namespace EF_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Det
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        [StringLength(50)]
        public string StudentName { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]
        public string Dept { get; set; }
    }
}
