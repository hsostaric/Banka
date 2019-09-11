//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankaHS.BLL
{
    using BankaHS.DAL.Repositories;
    using System;
    using System.Collections.Generic;

    public partial class Klijent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klijent()
        {
            this.Kredit_ = new HashSet<Kredit_>();
            this.Racun = new HashSet<Racun>();
            this.Stednja = new HashSet<Stednja>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public Nullable<bool> StalnoZaposlenje { get; set; }
        public Nullable<double> Primanja { get; set; }
        public string Adresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kredit_> Kredit_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stednja> Stednja { get; set; }

        public static List<Klijent> DOhvatiPopisSvihKlijenata()
        {
            return KlijentRepository.Instance.DohvatiSveKlijente();
        }
    }
}
