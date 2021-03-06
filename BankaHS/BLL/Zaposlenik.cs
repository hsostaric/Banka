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
    using BankaHS.ModelLayer.Repositories;
    using System;
    using System.Collections.Generic;

    public partial class Zaposlenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaposlenik()
        {
            this.Kredit_ = new HashSet<Kredit_>();
            this.Stednja = new HashSet<Stednja>();
        }
        public Zaposlenik(string ime, string prezime, string email, string adresa, string brojTelefona, string korisnickoIme, string lozinka, Tip_zaposlenika tip)
        {
            Ime = ime;
            Prezime = prezime;
            Email = email;
            Adresa = adresa;
            BrojTelefona = brojTelefona;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Tip_zaposlenika = tip;
            this.Kredit_ = new HashSet<Kredit_>();
            this.Stednja = new HashSet<Stednja>();
        }
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public Nullable<int> Tip_id { get; set; }
        public string Lozinka { get; set; }
        public static Zaposlenik PrijavljeniZaposlenik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kredit_> Kredit_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stednja> Stednja { get; set; }
        public virtual Tip_zaposlenika Tip_zaposlenika { get; set; }
        public bool provjeriPrijavu(string username, string password)
        {

            PrijavljeniZaposlenik = ZaposlenikRepository.ZaposlenikRepositoryInstance
                .DohvatiZaposlenika(username, password);
            return (PrijavljeniZaposlenik != null) ? true : false;

        }

        public static List<Zaposlenik> PrikazZaposlenika()
        {
            return ZaposlenikRepository.ZaposlenikRepositoryInstance.DohvatiZaposlenike();
        }
        public static List<Zaposlenik> PrikazZaposlenika(string argument, int opcija)
        {
            switch (opcija)
            {
                case 1:
                    return ZaposlenikRepository.ZaposlenikRepositoryInstance.DohvatiZaposlenike().FindAll(x => x.Ime.IndexOf(argument) > -1);
                case 2:
                    return ZaposlenikRepository.ZaposlenikRepositoryInstance.DohvatiZaposlenike().FindAll(x => x.Prezime.IndexOf(argument) > -1);
                default:
                    return null;
            }
        }
        public static List<Zaposlenik> PrikazZaposlenika(string argument, string argument2)
        {
            return ZaposlenikRepository.ZaposlenikRepositoryInstance.DohvatiZaposlenike().FindAll(x => x.Ime.IndexOf(argument) > -1 && x.Prezime.IndexOf(argument2) > -1);

        }

        public void DodajZaposlenika()
        {
            ZaposlenikRepository.ZaposlenikRepositoryInstance.Unos(this);

        }

        public void UrediZaposlenika(string ime, string prezime, string email, string lozinka, string korime, string adresa, string brojTelefona, Tip_zaposlenika tip)
        {
            ZaposlenikRepository.ZaposlenikRepositoryInstance.Uredi(this, ime, prezime, email, lozinka, korime, adresa, brojTelefona, tip);
        }

        public void ObrisiZaposlenika()
        {
            ZaposlenikRepository.ZaposlenikRepositoryInstance.Izbrisi(this);
        }

        public static List<Zaposlenik> DohvatiOdredjeneZaposlenike(Tip_zaposlenika tip)
        {
            return ZaposlenikRepository.ZaposlenikRepositoryInstance.DohvatiOdabraneTipoveZaposlenika(tip);
        }

        public static List<Zaposlenik> DohvatiOdredjeneZaposlenike(Tip_zaposlenika tip, string argument, int opcija)
        {
            switch (opcija)
            {
                case 1:
                    return ZaposlenikRepository.ZaposlenikRepositoryInstance.DohvatiOdabraneTipoveZaposlenika(tip).FindAll(x => x.Ime.IndexOf(argument) > -1);

                case 2:
                    return ZaposlenikRepository.ZaposlenikRepositoryInstance.DohvatiOdabraneTipoveZaposlenika(tip).FindAll(x => x.Prezime.IndexOf(argument) > -1);

                default:
                    return null;
            }

        }

        public static List<Zaposlenik> DohvatiOdredjeneZaposlenike(Tip_zaposlenika tip, string ime, string prezime)
        {
            return ZaposlenikRepository.ZaposlenikRepositoryInstance.DohvatiOdabraneTipoveZaposlenika(tip).FindAll(x => x.Ime.IndexOf(ime) > -1 && x.Ime.IndexOf(prezime) > -1);
        }
    }
}
