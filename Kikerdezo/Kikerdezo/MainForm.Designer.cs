namespace Kikerdezo
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segítségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.WorkPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.segítségToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitasToolStripMenuItem,
            this.bezarasToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitasToolStripMenuItem
            // 
            this.megnyitasToolStripMenuItem.Name = "megnyitasToolStripMenuItem";
            this.megnyitasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.megnyitasToolStripMenuItem.Text = "Kérdésbank megnyitása...";
            this.megnyitasToolStripMenuItem.Click += new System.EventHandler(this.megnyitasToolStripMenuItem_Click);
            // 
            // bezarasToolStripMenuItem
            // 
            this.bezarasToolStripMenuItem.Name = "bezarasToolStripMenuItem";
            this.bezarasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.bezarasToolStripMenuItem.Text = "Kérdésbank bezárása";
            this.bezarasToolStripMenuItem.Click += new System.EventHandler(this.bezarasToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // segítségToolStripMenuItem
            // 
            this.segítségToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.segítségToolStripMenuItem.Name = "segítségToolStripMenuItem";
            this.segítségToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.segítségToolStripMenuItem.Text = "Segítség";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.documentationToolStripMenuItem.Text = "Dokumentáció";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.infoToolStripMenuItem.Text = "Információ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // WorkPanel
            // 
            this.WorkPanel.AutoScroll = true;
            this.WorkPanel.BackColor = System.Drawing.SystemColors.Control;
            this.WorkPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.WorkPanel.ColumnCount = 3;
            this.WorkPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.WorkPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.WorkPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPanel.Location = new System.Drawing.Point(0, 24);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.RowCount = 2;
            this.WorkPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.WorkPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.WorkPanel.Size = new System.Drawing.Size(474, 288);
            this.WorkPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(474, 312);
            this.Controls.Add(this.WorkPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitasToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel WorkPanel;
        private System.Windows.Forms.ToolStripMenuItem bezarasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segítségToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

