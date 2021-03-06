﻿using BankaHS.PAL.PALInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankaHS.PAL.Validacije
{
    public class Validacija : IValidacije
    {
        public bool nazivKredita(string naziv)
        {
            return naziv.Length > 0 ? true : false;
        }

        public bool provjeraEmaila(string email)
        {
            string regex = @"^(?=^.{10,30}$)[A-z\d][A-z\d]*\.?[A-z\d]*@[A-z\d]+\.[A-z\d]{2,}$";
            return provjeraRegexa(email, regex) && email.Length > 0 ? true : false;
        }

        public bool provjeraImena(string ime)
        {
            return (ime.Length == 0) ? false : true;
        }

        public bool provjeraKamate(string kamatnaStopa)
        {
            string regex = @"^((\d){1,3}(\.|\,))?\d+$";
            return provjeraRegexa(kamatnaStopa, regex).Equals(true)
                && double.Parse(kamatnaStopa) <= 100 ? true : false;
        }

        public bool provjeraKorisnickogImena(string korisnickoIme)
        {
            string regex = "^[a-z0-9_-]{3,15}$";
            return provjeraRegexa(korisnickoIme, regex).Equals(true) && korisnickoIme.Length > 0 ? true : false;
        }



        public bool provjeraLozinke(string lozinka, string ponovljenaLozinka)
        {
            return (lozinka.Equals(ponovljenaLozinka) && lozinka.Length > 0) ? true : false;
        }

        public bool provjeraPrezimena(string prezime)
        {
            return prezime.Length > 0 ? true : false;
        }

        public bool provjeraRegexa(string polje, string izraz)
        {
            Regex regex = new Regex(@izraz);
            Match match = regex.Match(polje);
            return match.Success ? true : false;
        }

        public bool provjeriOIB(string oib)
        {
            string regex = "^[0-9]{11}$";
            return provjeraRegexa(oib, regex).Equals(true) ? true : false;
        }
    }
}
