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

namespace Zaključavanje_datoteke
{
    public partial class MainWindow : Form
    {
        private int timeLocked;
        private FileStream s;

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

        private void LockFile()
        {
            buttonSelect.Enabled = false;
            buttonLock.Enabled = false;
            textBoxTime.Enabled = false;

            s = new FileStream(openFileDialog.FileName, FileMode.Open);
            s.Lock(0, s.Length);

            timer.Interval = timeLocked;
            timer.Start();
        }

        private void UnlockFile()
        {
            s.Unlock(0, s.Length);
            s.Close();

            labelSelected.Text += " - OTKLJUČANO";
            buttonSelect.Enabled = true;
            buttonLock.Enabled = true;
            textBoxTime.Enabled = true;
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
                if (int.TryParse(textBoxTime.Text, out timeLocked))
                {
                    timeLocked *= 1000; //iz ms u s
                    buttonLock.Enabled = true;
                }
                else
                    MessageBox.Show("Unesite ispravno vrijeme!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            LockFile();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            UnlockFile();
        }
    }
}
