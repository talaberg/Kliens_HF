﻿namespace Kikerdezo
{
    partial class BrowseView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Kerdes = new System.Windows.Forms.Label();
            this.Megold = new System.Windows.Forms.Label();
            this.Valasz = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRand = new System.Windows.Forms.CheckBox();
            this.buttonElkuld = new System.Windows.Forms.Button();
            this.megoldBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.megoldBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kerdes
            // 
            this.Kerdes.AutoSize = true;
            this.Kerdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kerdes.Location = new System.Drawing.Point(34, 170);
            this.Kerdes.MaximumSize = new System.Drawing.Size(425, 0);
            this.Kerdes.Name = "Kerdes";
            this.Kerdes.Size = new System.Drawing.Size(70, 24);
            this.Kerdes.TabIndex = 0;
            this.Kerdes.Text = "Kerdes";
            this.Kerdes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Megold
            // 
            this.Megold.AutoSize = true;
            this.Megold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Megold.Location = new System.Drawing.Point(6, 28);
            this.Megold.MaximumSize = new System.Drawing.Size(425, 0);
            this.Megold.Name = "Megold";
            this.Megold.Size = new System.Drawing.Size(54, 17);
            this.Megold.TabIndex = 1;
            this.Megold.Text = "Megold";
            this.Megold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Valasz
            // 
            this.Valasz.Location = new System.Drawing.Point(38, 246);
            this.Valasz.Multiline = true;
            this.Valasz.Name = "Valasz";
            this.Valasz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Valasz.Size = new System.Drawing.Size(425, 87);
            this.Valasz.TabIndex = 2;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(172, 56);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.Next_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(22, 56);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 4;
            this.buttonPrevious.Text = "Előző";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.Previous_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRand);
            this.groupBox1.Controls.Add(this.buttonNext);
            this.groupBox1.Controls.Add(this.buttonPrevious);
            this.groupBox1.Location = new System.Drawing.Point(38, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kérdés léptetése";
            // 
            // checkBoxRand
            // 
            this.checkBoxRand.AutoSize = true;
            this.checkBoxRand.Location = new System.Drawing.Point(126, 19);
            this.checkBoxRand.Name = "checkBoxRand";
            this.checkBoxRand.Size = new System.Drawing.Size(136, 17);
            this.checkBoxRand.TabIndex = 5;
            this.checkBoxRand.Text = "Véletlenszerű kérdések";
            this.checkBoxRand.UseVisualStyleBackColor = true;
            this.checkBoxRand.CheckedChanged += new System.EventHandler(this.checkBoxRand_CheckedChanged);
            // 
            // buttonElkuld
            // 
            this.buttonElkuld.Location = new System.Drawing.Point(493, 283);
            this.buttonElkuld.Name = "buttonElkuld";
            this.buttonElkuld.Size = new System.Drawing.Size(75, 23);
            this.buttonElkuld.TabIndex = 6;
            this.buttonElkuld.Text = "Elküld";
            this.buttonElkuld.UseVisualStyleBackColor = true;
            this.buttonElkuld.Click += new System.EventHandler(this.elkuld_Click);
            // 
            // megoldBox
            // 
            this.megoldBox.AutoSize = true;
            this.megoldBox.Controls.Add(this.Megold);
            this.megoldBox.Location = new System.Drawing.Point(38, 399);
            this.megoldBox.Name = "megoldBox";
            this.megoldBox.Size = new System.Drawing.Size(425, 96);
            this.megoldBox.TabIndex = 7;
            this.megoldBox.TabStop = false;
            this.megoldBox.Text = "megoldBox";
            // 
            // BrowseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.megoldBox);
            this.Controls.Add(this.buttonElkuld);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Valasz);
            this.Controls.Add(this.Kerdes);
            this.Name = "BrowseView";
            this.Size = new System.Drawing.Size(654, 596);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.megoldBox.ResumeLayout(false);
            this.megoldBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kerdes;
        private System.Windows.Forms.Label Megold;
        private System.Windows.Forms.TextBox Valasz;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonElkuld;
        private System.Windows.Forms.GroupBox megoldBox;
        private System.Windows.Forms.CheckBox checkBoxRand;
    }
}
