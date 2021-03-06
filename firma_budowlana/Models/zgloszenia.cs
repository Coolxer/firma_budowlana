﻿//------------------------------------------------------------------------------
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

    public partial class zgloszenia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zgloszenia()
        {
            this.zlecenia = new HashSet<zlecenia>();
        }

        [Required]
        public int id { get; set; }

        [Required]
        public int autor_zgloszenia { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Opis może mieć maksymalnie 250 znaków")]
        public string opis { get; set; }

        [Required]
        public System.DateTime data_utworzenia { get; set; }

        public virtual klienci klienci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zlecenia> zlecenia { get; set; }
    }
}
