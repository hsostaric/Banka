﻿using BankaHS.BLL;
using BankaHS.PAL;
using BankaHS.PAL.AdminForme;
using BankaHS.PAL.Krediti;
using BankaHS.PAL.PALInterface;
using BankaHS.PAL.Stednje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaHS.PresentationLayer
{
    public partial class PocetanIzbornik : Form, IForme
    {
        public PocetanIzbornik()
        {
            InitializeComponent();
        }

        private void PocetanIzbornik_Load(object sender, EventArgs e)
        {

        }



        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdjaviMe(MessageBox.Show("Želite li se odjaviti sa sustava", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }

        public void OdjaviMe(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                Zaposlenik.PrijavljeniZaposlenik = null;
                this.Close();
            }
        }

        private void adminStraniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProvjeraAdmina().Equals(true))
            {
                AdminIzbornik adminIzbornik = new AdminIzbornik();
                this.Hide();
                adminIzbornik.ShowDialog();
                ProvjeraPrijave();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nemate pristup traženom području.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ProvjeraAdmina()
        {
            return (Tip_zaposlenika.ProvjeriPrijavljenog(Zaposlenik.PrijavljeniZaposlenik).Equals(true)) ? true : false;
        }

        public void ProvjeraPrijave()
        {
            if (Zaposlenik.PrijavljeniZaposlenik.Equals(null))
            {
                this.Close();
            }
        }

        public void PomocF1()
        {
            throw new NotImplementedException();
        }

        private void btnTecaj_Click(object sender, EventArgs e)
        {
            frmTecajnaLista forma = new frmTecajnaLista();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void gbIzbornik_Enter(object sender, EventArgs e)
        {

        }

        private void btnPregledKlijenta_Click(object sender, EventArgs e)
        {
            frmKlijenti klijenti = new frmKlijenti();
            this.Hide();
            klijenti.ShowDialog();
            this.Show();
        }

        private void tbnTransakcije_Click(object sender, EventArgs e)
        {

        }

        private void btnStednje_Click(object sender, EventArgs e)
        {
            OtvoriStednju forma = new OtvoriStednju();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void btnKrediti_Click(object sender, EventArgs e)
        {
            frmZahtjevZaKredit forma = new frmZahtjevZaKredit();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }
    }
}
