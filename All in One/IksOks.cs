using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIO
{
    public partial class IksOks : Form
    {
        int Brojac = 0;                                                                // Promenljiva za igrace, 0 je X, 1 je O.
        public IksOks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Brojac == 0)                                                           // Proverava na koga je red.
            {
                button1.Text = "X";
                Brojac++;
            }
            else if (Brojac == 1)
            {
                button1.Text = "O";
                Brojac--;
            }
            button1.Enabled = false;                                                    // Gasi dugme da bi sprecilo varanje.

            Provera();                                                                  // Proverava status igre (Pobeda ili nereseno).
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Brojac == 0)                                                           // Proverava na koga je red.
            {
                button2.Text = "X";
                Brojac++;
            }
            else if (Brojac == 1)
            {
                button2.Text = "O";
                Brojac--;
            }
            button2.Enabled = false;                                                    // Gasi dugme da bi sprecilo varanje.

            Provera();                                                                  // Proverava status igre (Pobeda ili nereseno).
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Brojac == 0)                                                           // Proverava na koga je red.
            {
                button3.Text = "X";
                Brojac++;
            }
            else if (Brojac == 1)
            {
                button3.Text = "O";
                Brojac--;
            }
            button3.Enabled = false;                                                    // Gasi dugme da bi sprecilo varanje.

            Provera();                                                                  // Proverava status igre (Pobeda ili nereseno).
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Brojac == 0)                                                           // Proverava na koga je red.
            {
                button4.Text = "X";
                Brojac++;
            }
            else if (Brojac == 1)
            {
                button4.Text = "O";
                Brojac--;
            }
            button4.Enabled = false;                                                    // Gasi dugme da bi sprecilo varanje.

            Provera();                                                                  // Proverava status igre (Pobeda ili nereseno).
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Brojac == 0)                                                           // Proverava na koga je red.
            {
                button5.Text = "X";
                Brojac++;
            }
            else if (Brojac == 1)
            {
                button5.Text = "O";
                Brojac--;
            }
            button5.Enabled = false;                                                    // Gasi dugme da bi sprecilo varanje.

            Provera();                                                                  // Proverava status igre (Pobeda ili nereseno).
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Brojac == 0)                                                           // Proverava na koga je red.
            {
                button6.Text = "X";
                Brojac++;
            }
            else if (Brojac == 1)
            {
                button6.Text = "O";
                Brojac--;
            }
            button6.Enabled = false;                                                    // Gasi dugme da bi sprecilo varanje.

            Provera();                                                                  // Proverava status igre (Pobeda ili nereseno).
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Brojac == 0)                                                           // Proverava na koga je red.
            {
                button7.Text = "X";
                Brojac++;
            }
            else if (Brojac == 1)
            {
                button7.Text = "O";
                Brojac--;
            }
            button7.Enabled = false;                                                    // Gasi dugme da bi sprecilo varanje.

            Provera();                                                                  // Proverava status igre (Pobeda ili nereseno).
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Brojac == 0)                                                           // Proverava na koga je red.
            {
                button8.Text = "X";
                Brojac++;
            }
            else if (Brojac == 1)
            {
                button8.Text = "O";
                Brojac--;
            }
            button8.Enabled = false;                                                    // Gasi dugme da bi sprecilo varanje.

            Provera();                                                                  // Proverava status igre (Pobeda ili nereseno).
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Brojac == 0)                                                           // Proverava na koga je red.
            {
                button9.Text = "X";
                Brojac++;
            }
            else if (Brojac == 1)
            {
                button9.Text = "O";
                Brojac--;
            }
            button9.Enabled = false;                                                    // Gasi dugme da bi sprecilo varanje.

            Provera();                                                                  // Proverava status igre (Pobeda ili nereseno).
        }

        void Provera()
        {

            {
                if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                    MessageBox.Show("X je pobedio");
                    return;
                }                                                                    // Provera dijagonale za pobedu X
                if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                    MessageBox.Show("X je pobedio");
                    return;

                }
            }                                                                         // Provera dijagonale za pobedu X
            {
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                    MessageBox.Show("X je pobedio");
                    return;
                }
                if(button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                    MessageBox.Show("X je pobedio");
                    return;
                }
                if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                    MessageBox.Show("X je pobedio");
                    return;
                }
            }                                                                         // Provera redova za pobedu X
            {
                if(button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                    MessageBox.Show("X je pobedio");
                    return;
                }
                if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                    MessageBox.Show("X je pobedio");
                    return;
                }
                if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                    MessageBox.Show("X je pobedio");
                    return;
                }
            }                                                                         // Provera kolona za pobedu X

            {
                if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                    MessageBox.Show("O je pobedio");
                    return;
                }
                if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                    MessageBox.Show("O je pobedio");
                    return;
                }
            }                                                                         // Provera dijagonale za pobedu O
            {
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                    MessageBox.Show("O je pobedio");
                    return;
                }
                if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                    MessageBox.Show("O je pobedio");
                    return;
                }
                if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                    MessageBox.Show("O je pobedio");
                    return;
                }
            }                                                                         // Provera redova za pobedu O
            {
                if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                    MessageBox.Show("O je pobedio");
                    return;
                }
                if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                    MessageBox.Show("O je pobedio");
                    return;
                }
                if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                    MessageBox.Show("O je pobedio");
                    return;
                }
            }                                                                         // Provera kolona za pobedu O

            {
                if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                    button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                    button7.Text != "" && button8.Text != "" && button9.Text != "")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    MessageBox.Show("Nereseno");
                    return;
                }
            }                                                                         // Provera za nereseno.

        }                                                              // Proverava status igre (Pobeda ili nereseno).

        private void IksOks_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Brojac = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    c.Enabled = true;
                    c.Text = ""; 
                }
            }

        }               // Nova igra

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "0";
        }               // Reset brojaca

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
