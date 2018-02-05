namespace PublierDocuments2017
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mombre")]
    public partial class Mombre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mombre()
        {
            Commentaire = new HashSet<Commentaire>();
        }

        [Key]
        [StringLength(50)]
        public string login_ { get; set; }

        [StringLength(50)]
        public string passe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commentaire> Commentaire { get; set; }
    }
}
