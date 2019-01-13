/*

.. 19.12.18. AIO V2 POCETAK.       .. 15.01.19. AIO V2 ZAVRSEN.

                                                           303. 
                                                  Marko Prugic.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class aio : Form
    {
        public aio()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            t.Abort();
        }                                                                            // Spalsh Screen, zapravo ne radi nista ali lepo izgleda.

        public void StartForm() => Application.Run(new SplashScreen());                            // Otvara Splash Screen.

        private void frmMain_Load(object sender, EventArgs e)
        {

        }                                   // Otvara glavni prozor.

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }                                   // Label (Polje) za prikazivanje trenutnog datuma i vremena.

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }                                    // Timer (Brojac) za osvezavanje tranutnog datuma i vremena.

        private void label3_Click(object sender, EventArgs e)
        {

        }                                   // Label (Polje) za prikazivanje naziva programa koji odgovara imenu i ikoni.

        private void label4_Click(object sender, EventArgs e)
        {

        }                                   // Label (Polje) za prikazivanje naziva programa koji odgovara imenu i ikoni.

        private void button2_Click(object sender, EventArgs e)
        {
            Sveska.Notepad Notepad = new Sveska.Notepad();
            Notepad.ShowDialog();
        }                                  // Dugme za otvaranje prozora za svesku.

        private void button6_Click(object sender, EventArgs e)
        {
            AIO.IksOks IksOks  = new AIO.IksOks();
            IksOks.ShowDialog();
        }                                  // Dugme za otvaranje prozora za igru iks oks.

        private void Button8_Click(object sender, EventArgs e)
        {
            var form = new AIO.planer();
            form.ShowDialog();
        }                                  // Dugme za otvaranje prozora za planer.

        private void Calc_Click(object sender, EventArgs e)
        {
            Calculator.Form1 form1 = new Calculator.Form1();
            form1.ShowDialog();
        }                                     // Dugme za otvaranje prozora za digitron.

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da zelite da izadjete?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)            // Potvrda za izlazak.
            {
                this.Close();
            }
        }                                     // Dugme za izlaz iz glavnog prozora.

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }                                  // Dugme za otvaranje "About" prozora.
    }
}
