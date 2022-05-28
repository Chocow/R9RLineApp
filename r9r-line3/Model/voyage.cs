namespace r9r_line3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("r9r-line.voyage")]
    public partial class voyage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IDVOYAGE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string NOMVOYAGE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string TYPEVOYAGE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string STOCKVOYAGE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string PAYSVOYAGE { get; set; }

        public byte[] IMAGEVOYAGE { get; set; }

        public int? PrixVoyage { get; set; }
    }
}
