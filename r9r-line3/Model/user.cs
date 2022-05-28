namespace r9r_line3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("r9r-line.users")]
    public partial class user
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string email { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string mdp { get; set; }
    }
}
