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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(655, 69);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(75, 23);
            this.buttonLock.TabIndex = 0;
            this.buttonLock.Text = "Zaključaj";
            this.buttonLock.UseVisualStyleBackColor = true;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(29, 69);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(105, 23);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Odaberi datoteku";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(166, 74);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(99, 13);
            this.labelSelected.TabIndex = 2;
            this.labelSelected.Text = "Odabrana datoteka";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(506, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(503, 52);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(111, 13);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Vrijeme u sekundama:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonLock);
            this.Name = "MainWindow";
            this.Text = "Zaključavanje datoteka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
    }
}

