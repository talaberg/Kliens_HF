namespace Kikerdezo
{
    partial class MainMenu
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
            this.browse = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browse.Location = new System.Drawing.Point(17, 15);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(89, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "Böngészés";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // test
            // 
            this.test.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.test.Location = new System.Drawing.Point(119, 15);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(89, 23);
            this.test.TabIndex = 1;
            this.test.Text = "Teszt indítása";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit.Location = new System.Drawing.Point(220, 15);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(89, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "Szerkesztés";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.browse);
            this.panel1.Controls.Add(this.test);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 52);
            this.panel1.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(330, 61);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Panel panel1;
    }
}
