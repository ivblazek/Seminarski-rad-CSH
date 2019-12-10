using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaključavanje_datoteke
{
    public partial class MainWindow : Form
    {
        private uint timeLocked;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelSelected.Text = openFileDialog.FileName;
                textBoxTime.Enabled = true;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {
            buttonLock.Enabled = false;
            if (textBoxTime.Text!="")
            {
                if (uint.TryParse(textBoxTime.Text, out timeLocked))
                {
                    timeLocked *= 1000; //iz ms u s
                    buttonLock.Enabled = true;
                }
                else
                    MessageBox.Show("Unesite ispravno vrijeme!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
