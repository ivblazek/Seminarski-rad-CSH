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
        private FileStream fileToLock;
        private string csvPath = "history.csv";

        public MainWindow()
        {
            InitializeComponent();
            ReadCSV();
        }

        private void WriteCSV()
        {
            StringBuilder result = new StringBuilder();
            StreamWriter historyFile;
            
            try
            {
                historyFile = File.AppendText(csvPath);
                result.AppendFormat("\"{0}\",", listViewHistory.Items[0].Text);
                for (int j = 1; j < listViewHistory.Items[0].SubItems.Count; ++j)
                {
                    if (j < listViewHistory.Items[0].SubItems.Count - 1)
                        result.AppendFormat("\"{0}\",", listViewHistory.Items[0].SubItems[j].Text);
                    else
                        result.AppendFormat("\"{0}\"", listViewHistory.Items[0].SubItems[j].Text);
                }
                result.AppendLine();

                historyFile.Write(result.ToString());
                historyFile.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadCSV()
        {
            StringBuilder result = new StringBuilder();
            StreamReader historyFile;
            try
            {
                if(File.Exists(csvPath))
                {
                    historyFile = new StreamReader(File.OpenRead(csvPath));
                    while (!historyFile.EndOfStream)
                    {
                        string line = historyFile.ReadLine();
                        string[] values = line.Split(',');
                        ListViewItem entery = new ListViewItem();

                        values[0] = values[0].Remove(0, 1);
                        values[0] = values[0].Remove(values[0].Length - 1);
                        entery.Text = (values[0]);
                        for (int i = 1; i < values.Length; ++i)
                        {
                            values[i] = values[i].Remove(0, 1);
                            values[i] = values[i].Remove(values[i].Length - 1);
                            entery.SubItems.Add(values[i]);
                        }

                        listViewHistory.Items.Insert(0, entery);
                    }

                    historyFile.Close();
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
            labelSelected.Text = openFileDialog.FileName;
            try
            {
                fileToLock = new FileStream(openFileDialog.FileName, FileMode.Open);
                buttonSelect.Enabled = false;
                buttonLock.Enabled = false;
                textBoxTime.Enabled = false;
                radioButtonMS.Enabled = false;
                radioButtonS.Enabled = false;
                listViewHistory.Enabled = false;
                
                fileToLock.Lock(0, fileToLock.Length);

                timer.Start();
                timePassed = 0;

                WriteCSV();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exceptionLock();
            }
            catch(IOException e)
            {
                MessageBox.Show(e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exceptionLock();
            }
        }
        private void exceptionLock()
        {
            listViewHistory.Items[0].Remove();
            labelSelected.Text = "Trenutno NIJE odabrana datoteka";
            textBoxTime.Text = "";
            textBoxTime.Enabled = false;
            radioButtonMS.Enabled = false;
            radioButtonS.Enabled = false;
        }

        private void UnlockFile()
        {
            fileToLock.Unlock(0, fileToLock.Length);
            fileToLock.Close();

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
                textBoxTime.Enabled = true;
                radioButtonMS.Enabled = true;
                radioButtonS.Enabled = true;
            }       
        }
    }
}
