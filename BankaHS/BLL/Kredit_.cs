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

    public partial class Kredit_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kredit_()
        {
            this.Otplatna_tablica = new HashSet<Otplatna_tablica>();
        }

        public Kredit_(DateTime _datumPocetka, double _ks, double _glavnica, int _rokOtplate, string _nazivKredita)
        {
            DatumPocetka = _datumPocetka;
            Glavnica = _glavnica;
            RokOtplate = _rokOtplate;
            NazivKredita = _nazivKredita;
            KamatnaStopa = _ks;
            Status = 1;
        }

        public int Id { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> DatumPocetka { get; set; }
        public double Glavnica { get; set; }
        public int RokOtplate { get; set; }
        public Nullable<int> Zaposlenik_id { get; set; }
        public Nullable<int> Klijent_id { get; set; }
        public double KamatnaStopa { get; set; }
        public string NazivKredita { get; set; }

        public List<Otplatna_tablica> KolekcijaZapisa = new List<Otplatna_tablica>();
        public virtual Klijent Klijent { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Otplatna_tablica> Otplatna_tablica { get; set; }

        public double IzracunajRekurzivnuKamatnuStopu()
        {
            double p = this.KamatnaStopa / 12;
            double pom = 1 + (p / 100);
            return pom;
        }

        public double IzracunajAnuitet(double r)
        {
            double gornjiDio = 0;
            double donjiDio = 0;
            gornjiDio = Math.Pow(r, RokOtplate) * (r - 1);
            donjiDio = Math.Pow(r, this.RokOtplate) - 1;
            double anuitet = Glavnica * (gornjiDio / donjiDio);
            return Math.Round(anuitet, 2);
        }

        public double IzracunajKamatuRazdoblja(double ostatakDuga, double r)
        {
            return Math.Round(ostatakDuga * (r - 1), 2);
        }

        public double IzracunajOtplatnuKvotu(double anuitet, double kamataRazdoblja)
        {
            return Math.Round(anuitet - kamataRazdoblja, 3);
        }

        public double IzracunajOtplaceniDioDuga(double dio, double kvota)
        {
            return Math.Round(dio + kvota, 2);
        }

        public double IzracunajOstatakDUga(double ostatak, double kvota)
        {
            double ostatakDuga = Math.Round(ostatak - kvota, 2);
            return ostatakDuga;
        }
        public void IzracunajOtplatnuTablicu()
        {
            double ostatakDuga = 0;
            ostatakDuga = this.Glavnica;
            double otplatnaKvota = 0;
            double otplaceniDioDuga = 0;
            double kamataRazdoblja = 0;


            for (int i = 0; i < this.RokOtplate; i++)
            {
                kamataRazdoblja = IzracunajKamatuRazdoblja(ostatakDuga, IzracunajRekurzivnuKamatnuStopu());

                otplatnaKvota = IzracunajOtplatnuKvotu(IzracunajAnuitet(IzracunajRekurzivnuKamatnuStopu()), kamataRazdoblja);
                otplaceniDioDuga = IzracunajOtplaceniDioDuga(otplaceniDioDuga, otplatnaKvota);

                DodajZapisUOtplatnu(new Otplatna_tablica(kamataRazdoblja, IzracunajAnuitet(IzracunajRekurzivnuKamatnuStopu()),
                    otplatnaKvota, ostatakDuga, otplaceniDioDuga, i + 1));
                ostatakDuga = IzracunajOstatakDUga(ostatakDuga, otplatnaKvota);
            }
        }

        public void DodajZapisUOtplatnu(Otplatna_tablica otplata)
        {
            this.KolekcijaZapisa.Add(otplata);
        }

    }
}
