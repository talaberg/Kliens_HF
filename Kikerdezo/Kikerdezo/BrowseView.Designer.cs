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
            this.SuspendLayout();
            // 
            // Kerdes
            // 
            this.Kerdes.AutoSize = true;
            this.Kerdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kerdes.Location = new System.Drawing.Point(161, 28);
            this.Kerdes.Name = "Kerdes";
            this.Kerdes.Size = new System.Drawing.Size(70, 24);
            this.Kerdes.TabIndex = 0;
            this.Kerdes.Text = "Kerdes";
            this.Kerdes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Megold
            // 
            this.Megold.AutoSize = true;
            this.Megold.Location = new System.Drawing.Point(174, 109);
            this.Megold.Name = "Megold";
            this.Megold.Size = new System.Drawing.Size(42, 13);
            this.Megold.TabIndex = 1;
            this.Megold.Text = "Megold";
            this.Megold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Valasz
            // 
            this.Valasz.Location = new System.Drawing.Point(124, 184);
            this.Valasz.Name = "Valasz";
            this.Valasz.Size = new System.Drawing.Size(151, 20);
            this.Valasz.TabIndex = 2;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(287, 245);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(43, 245);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 4;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            // 
            // BrowseQView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Valasz);
            this.Controls.Add(this.Megold);
            this.Controls.Add(this.Kerdes);
            this.Name = "BrowseQView";
            this.Size = new System.Drawing.Size(404, 337);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kerdes;
        private System.Windows.Forms.Label Megold;
        private System.Windows.Forms.TextBox Valasz;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
    }
}
