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
    using System;
    using System.Collections.Generic;
    
    public partial class Racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Racun()
        {
            this.Transakcija = new HashSet<Transakcija>();
            this.Transakcija1 = new HashSet<Transakcija>();
        }
    
        public string BrojKartice { get; set; }
        public double Saldo { get; set; }
        public Nullable<int> Blokiran { get; set; }
        public Nullable<int> Klijent_id { get; set; }
        public string IBAN { get; set; }
        public string KontrolniBroj { get; set; }
        public int PIN { get; set; }
    
        public virtual DevizniRacun DevizniRacun { get; set; }
        public virtual Klijent Klijent { get; set; }
        public virtual TekuciRacun TekuciRacun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transakcija> Transakcija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transakcija> Transakcija1 { get; set; }
        public virtual ZiroRacun ZiroRacun { get; set; }
    }
}
