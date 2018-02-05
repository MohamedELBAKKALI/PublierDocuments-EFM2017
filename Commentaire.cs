namespace PublierDocuments2017
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commentaire")]
    public partial class Commentaire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code_commentaire { get; set; }

        public DateTime? date_commentaire { get; set; }

        [StringLength(50)]
        public string text_commentaire { get; set; }

        [StringLength(50)]
        public string etat_commentaire { get; set; }

        public int? code_document { get; set; }

        [StringLength(50)]
        public string login_ { get; set; }

        public virtual Document Document { get; set; }

        public virtual Mombre Mombre { get; set; }
    }
}
