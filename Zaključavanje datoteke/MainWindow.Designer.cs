﻿namespace Zaključavanje_datoteke
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelSelected = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.radioButtonMS = new System.Windows.Forms.RadioButton();
            this.radioButtonS = new System.Windows.Forms.RadioButton();
            this.panelRadio = new System.Windows.Forms.Panel();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lockedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonLock
            // 
            this.buttonLock.Enabled = false;
            this.buttonLock.Location = new System.Drawing.Point(655, 69);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(75, 23);
            this.buttonLock.TabIndex = 0;
            this.buttonLock.Text = "Zaključaj";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(29, 69);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(105, 23);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Odaberi datoteku";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(166, 74);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(169, 13);
            this.labelSelected.TabIndex = 2;
            this.labelSelected.Text = "Trenutno NIJE odabrana datoteka";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Location = new System.Drawing.Point(506, 72);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(63, 20);
            this.textBoxTime.TabIndex = 3;
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBoxTime_TextChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(503, 52);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 13);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Vrijeme:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // radioButtonMS
            // 
            this.radioButtonMS.AutoSize = true;
            this.radioButtonMS.Checked = true;
            this.radioButtonMS.Enabled = false;
            this.radioButtonMS.Location = new System.Drawing.Point(575, 73);
            this.radioButtonMS.Name = "radioButtonMS";
            this.radioButtonMS.Size = new System.Drawing.Size(38, 17);
            this.radioButtonMS.TabIndex = 5;
            this.radioButtonMS.TabStop = true;
            this.radioButtonMS.Text = "ms";
            this.radioButtonMS.UseVisualStyleBackColor = true;
            // 
            // radioButtonS
            // 
            this.radioButtonS.AutoSize = true;
            this.radioButtonS.Enabled = false;
            this.radioButtonS.Location = new System.Drawing.Point(619, 73);
            this.radioButtonS.Name = "radioButtonS";
            this.radioButtonS.Size = new System.Drawing.Size(30, 17);
            this.radioButtonS.TabIndex = 6;
            this.radioButtonS.Text = "s";
            this.radioButtonS.UseVisualStyleBackColor = true;
            // 
            // panelRadio
            // 
            this.panelRadio.Location = new System.Drawing.Point(575, 72);
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Size = new System.Drawing.Size(74, 20);
            this.panelRadio.TabIndex = 7;
            // 
            // listViewHistory
            // 
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.path,
            this.dateTime,
            this.lockedTime,
            this.precision});
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(29, 196);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(701, 170);
            this.listViewHistory.TabIndex = 8;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            this.listViewHistory.SelectedIndexChanged += new System.EventHandler(this.listViewHistory_SelectedIndexChanged);
            // 
            // path
            // 
            this.path.Text = "Path";
            this.path.Width = 430;
            // 
            // dateTime
            // 
            this.dateTime.Text = "Date Time";
            this.dateTime.Width = 110;
            // 
            // lockedTime
            // 
            this.lockedTime.Text = "Locked Time";
            this.lockedTime.Width = 80;
            // 
            // precision
            // 
            this.precision.Text = "Precision";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.radioButtonS);
            this.Controls.Add(this.radioButtonMS);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.panelRadio);
            this.Name = "MainWindow";
            this.Text = "Zaključavanje datoteka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton radioButtonMS;
        private System.Windows.Forms.RadioButton radioButtonS;
        private System.Windows.Forms.Panel panelRadio;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.ColumnHeader dateTime;
        private System.Windows.Forms.ColumnHeader lockedTime;
        private System.Windows.Forms.ColumnHeader precision;
    }
}

