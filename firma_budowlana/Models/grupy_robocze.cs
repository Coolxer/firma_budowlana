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

    public partial class grupy_robocze
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public grupy_robocze()
        {
            this.pracownicy = new HashSet<pracownicy>();
        }

        [Required]
        public int id { get; set; }

        [Required]
        public int kierownik { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Nazwa specjalizacji nie powinna przekraczać 30 znaków")]
        public string specjalizacja { get; set; }

        public virtual kierownicy kierownicy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pracownicy> pracownicy { get; set; }
    }
}
