namespace r9r_line3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("r9r-line.commande")]
    public partial class commande
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IDCOMMANDE { get; set; }

        public short IDCLIENT { get; set; }

        public int? PRIXCOMMANDE { get; set; }
    }
}
