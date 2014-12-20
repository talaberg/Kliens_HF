namespace Kikerdezo
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
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elkuld = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kerdes
            // 
            this.Kerdes.AutoSize = true;
            this.Kerdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kerdes.Location = new System.Drawing.Point(51, 171);
            this.Kerdes.MaximumSize = new System.Drawing.Size(300, 0);
            this.Kerdes.Name = "Kerdes";
            this.Kerdes.Size = new System.Drawing.Size(70, 24);
            this.Kerdes.TabIndex = 0;
            this.Kerdes.Text = "Kerdes";
            this.Kerdes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Megold
            // 
            this.Megold.AutoSize = true;
            this.Megold.Location = new System.Drawing.Point(52, 422);
            this.Megold.MaximumSize = new System.Drawing.Size(300, 0);
            this.Megold.Name = "Megold";
            this.Megold.Size = new System.Drawing.Size(42, 13);
            this.Megold.TabIndex = 1;
            this.Megold.Text = "Megold";
            this.Megold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Valasz
            // 
            this.Valasz.Location = new System.Drawing.Point(55, 252);
            this.Valasz.Multiline = true;
            this.Valasz.Name = "Valasz";
            this.Valasz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Valasz.Size = new System.Drawing.Size(379, 87);
            this.Valasz.TabIndex = 2;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(108, 56);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(17, 56);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 4;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Next);
            this.groupBox1.Controls.Add(this.Previous);
            this.groupBox1.Location = new System.Drawing.Point(38, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kérdés léptetése";
            // 
            // elkuld
            // 
            this.elkuld.Location = new System.Drawing.Point(493, 283);
            this.elkuld.Name = "elkuld";
            this.elkuld.Size = new System.Drawing.Size(75, 23);
            this.elkuld.TabIndex = 6;
            this.elkuld.Text = "Elküld";
            this.elkuld.UseVisualStyleBackColor = true;
            // 
            // BrowseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.elkuld);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Valasz);
            this.Controls.Add(this.Megold);
            this.Controls.Add(this.Kerdes);
            this.Name = "BrowseView";
            this.Size = new System.Drawing.Size(654, 596);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kerdes;
        private System.Windows.Forms.Label Megold;
        private System.Windows.Forms.TextBox Valasz;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button elkuld;
    }
}
