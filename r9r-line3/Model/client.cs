namespace r9r_line3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("r9r-line.client")]
    public partial class client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IDCLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string NOMCLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string PRENOMCLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string AGECLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string ADRESSECLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string MAILCLIENT { get; set; }
    }
}
