//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace firma_budowlana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class umowy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public umowy()
        {
            this.faktury = new HashSet<faktury>();
        }

        [Required]
        public int id { get; set; }

        [Required]
        public int nr_zlecenia { get; set; }

        [Required]
        public string typ { get; set; }

        [Required]
        public System.DateTime data_wystawienia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<faktury> faktury { get; set; }
        public virtual zlecenia zlecenia { get; set; }
    }
}
