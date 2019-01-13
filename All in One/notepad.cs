using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sveska
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }                           // Funkcija "Cut" za izabrani tekst.

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }                           // Ciscenje prozora.

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            this.Text = op.FileName;

        }                          // Dijalog za otvaranje fajla.

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sv.FileName;

        }                          // Dijalog za cuvanje fajla.

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }                          // Zatvaranje prozora.

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }                          // Funkcija "Copy" za izabrani tekst.

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }                         // Funkcija "Paste" za izabrani tekst.

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }                          // Funkcija "Undo".

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }                          // Funkcija "Redo".

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }                     // Dijalog za promenu fonta.

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cr = new ColorDialog();
            if (cr.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = cr.Color;
            }
        }                       // Dijalog za promenu boje pozadine.

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }                                        // Zatvaranje prozora.

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Notepad_Load(object sender, EventArgs e)
        {

        }
    }
    }

