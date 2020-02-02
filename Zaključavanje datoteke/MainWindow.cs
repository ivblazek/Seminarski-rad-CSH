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
        private int timePassed;
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
                radioButtonMS.Enabled = true;
                radioButtonS.Enabled = true;
            }
        }

        private void LockFile()
        {
            buttonSelect.Enabled = false;
            buttonLock.Enabled = false;
            textBoxTime.Enabled = false;
            radioButtonMS.Enabled = false;
            radioButtonS.Enabled = false;
            listViewHistory.Enabled = false;

            labelSelected.Text = openFileDialog.FileName;
            s = new FileStream(openFileDialog.FileName, FileMode.Open);
            s.Lock(0, s.Length);

            timer.Start();
            timePassed = 0;
        }

        private void UnlockFile()
        {
            s.Unlock(0, s.Length);
            s.Close();

            labelSelected.Text += " - OTKLJUČANO";
            buttonSelect.Enabled = true;
            textBoxTime.Enabled = true;
            radioButtonMS.Enabled = true;
            radioButtonS.Enabled = true;
            listViewHistory.Enabled = true;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {
            if (timePassed == 0) 
            {
                buttonLock.Enabled = false;
                if (textBoxTime.Text != "")
                {
                    if (int.TryParse(textBoxTime.Text, out timeLocked))
                        buttonLock.Enabled = true;
                    else
                    {
                        MessageBox.Show("Unesite ispravno vrijeme!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxTime.Text = textBoxTime.Text.Remove(textBoxTime.Text.Length - 1);
                    }
                }
            }
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            ListViewItem entery = new ListViewItem(openFileDialog.FileName);
            entery.SubItems.Add(DateTime.Now.ToString());
            entery.SubItems.Add(timeLocked.ToString());
                        
            if (radioButtonS.Checked)
            {
                timer.Interval = 1000;
                entery.SubItems.Add("s");
            }
            else
            {
                timer.Interval = timeLocked;
                timeLocked = 1;
                entery.SubItems.Add("ms");
            }

            listViewHistory.Items.Insert(0, entery);
            LockFile();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timePassed += 1;
            textBoxTime.Text = (timeLocked - timePassed).ToString();
            if (timePassed == timeLocked)
            {
                timer.Stop();
                UnlockFile();
                timePassed = 0;
                textBoxTime.Text = "";
            }
        }
        private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedItems.Count != 0)
            {
                openFileDialog.FileName = listViewHistory.SelectedItems[0].Text;
                labelSelected.Text = openFileDialog.FileName;
                textBoxTime.Text= listViewHistory.SelectedItems[0].SubItems[2].Text;
                if (listViewHistory.SelectedItems[0].SubItems[3].Text.Equals("s"))
                    radioButtonS.Checked = true;
                else
                    radioButtonMS.Checked = true;
            }       
        }
    }
}
