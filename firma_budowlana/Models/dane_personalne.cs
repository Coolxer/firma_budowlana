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

    public partial class dane_personalne
    {
        [Required]
        public int id { get; set; }

        [Required]
        [RegularExpression("^[Aa��BbCc��DdEe��FfGgHhIiJjKkLl��MmNn��Oo��PpRrSs��TtUuWwYyZz����]{3,50}", ErrorMessage = "Imie musi zawiera� same litery. Miniumum 3, maksimum 50")]
        public string imie { get; set; }

        [Required]
        [RegularExpression("^[Aa��BbCc��DdEe��FfGgHhIiJjKkLl��MmNn��Oo��PpRrSs��TtUuWwYyZz����]{3,50}", ErrorMessage = "Nazwisko musi zawiera� same litery. Miniumum 3, maksimum 50")]
        public string nazwisko { get; set; }

        [Required]
        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Pesel musi mie� dok�adnie 11 cyfr")]
        public string pesel { get; set; }

        [Required(ErrorMessage = "Pole telefon jest wymagane")]
        [RegularExpression("^[0-9]{3}-[0-9]{3}-[0-9]{3}$", ErrorMessage = "Podaj numer w formacie 123-456-789")]
        public string nr_telefonu { get; set; }

        [Required]
        [RegularExpression(".{1,}@.{1,}", ErrorMessage = "Podaj poprawny email")]
        public string email { get; set; }

        public string fullName
        {
            get { return this.imie + " " + this.nazwisko + " " + this.pesel; }
        }

        public virtual kierownicy kierownicy { get; set; }
        public virtual klienci klienci { get; set; }
        public virtual pracownicy pracownicy { get; set; }
    }
}