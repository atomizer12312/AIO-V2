using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIO
{
    public partial class planer : Form
    {
        public planer()
        {
            InitializeComponent();
            DataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private static podaci_planer db;
        protected static podaci_planer App
        {
            get
            {
                if (db == null)
                    db = new podaci_planer();
                return db;
            }
        }

        private void planer_Load(object sender, EventArgs e)
        {
            DataGridView1.AutoGenerateColumns = true;
            string fileName = string.Format("{0}//podaci.dat", Application.StartupPath);
            if (File.Exists(fileName))
            App.Planer.ReadXml(fileName);
            planerBindingSource.DataSource = App.Planer;
        }                                                        // Citanje fajla sa podacima.

        private void DataGridView1_CellContentClick_1(object sender, KeyEventArgs e, KeyEventArgs k)
        {
            if (k.KeyData == Keys.Delete)
            {
                planerBindingSource.RemoveCurrent();
            }
        }                // Brisanje izabrane celije.
        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                planerBindingSource.EndEdit();
                App.Planer.WriteXml(string.Format("{0}//podaci.dat", Application.StartupPath));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.Planer.RejectChanges();
            }

        }                                           // Cuvanje unosa.

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = null;
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
        }                                   // Ciscenje svih unosa u listi.

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
            base.OnFormClosing(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}