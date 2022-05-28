namespace r9r_line3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("r9r-line.contact")]
    public partial class contact
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Prenom_Contact { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Nom_Contact { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Email_Contact { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(350)]
        public string Message_Contact { get; set; }
    }
}
