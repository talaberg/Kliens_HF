using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kikerdezo
{
    public partial class TestView : UserControl, QView
    {
        private Timer timerTest;
        private GroupBox groupBoxTestParam;
        private Button bTestStart;
        private NumericUpDown numSetQnum;
        private Label labelQuestions;
        private NumericUpDown numSetTestTime;
        private Label labelTestTime;
        private GroupBox groupBoxTimer;
        private Label labelTimer;
        private IContainer components;
        private TableLayoutPanel tableTest;
        private Panel panelTableHolder;
        private Button bEnd;

        


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.groupBoxTestParam = new System.Windows.Forms.GroupBox();
            this.bTestStart = new System.Windows.Forms.Button();
            this.numSetQnum = new System.Windows.Forms.NumericUpDown();
            this.labelQuestions = new System.Windows.Forms.Label();
            this.numSetTestTime = new System.Windows.Forms.NumericUpDown();
            this.labelTestTime = new System.Windows.Forms.Label();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.bEnd = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.tableTest = new System.Windows.Forms.TableLayoutPanel();
            this.panelTableHolder = new System.Windows.Forms.Panel();
            this.groupBoxTestParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetQnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetTestTime)).BeginInit();
            this.groupBoxTimer.SuspendLayout();
            this.panelTableHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTest
            // 
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // groupBoxTestParam
            // 
            this.groupBoxTestParam.Controls.Add(this.bTestStart);
            this.groupBoxTestParam.Controls.Add(this.numSetQnum);
            this.groupBoxTestParam.Controls.Add(this.labelQuestions);
            this.groupBoxTestParam.Controls.Add(this.numSetTestTime);
            this.groupBoxTestParam.Controls.Add(this.labelTestTime);
            this.groupBoxTestParam.Location = new System.Drawing.Point(37, 19);
            this.groupBoxTestParam.Name = "groupBoxTestParam";
            this.groupBoxTestParam.Size = new System.Drawing.Size(401, 128);
            this.groupBoxTestParam.TabIndex = 0;
            this.groupBoxTestParam.TabStop = false;
            this.groupBoxTestParam.Text = "Teszt paraméterei";
            // 
            // bTestStart
            // 
            this.bTestStart.Location = new System.Drawing.Point(307, 56);
            this.bTestStart.Name = "bTestStart";
            this.bTestStart.Size = new System.Drawing.Size(75, 23);
            this.bTestStart.TabIndex = 5;
            this.bTestStart.Text = "Start!";
            this.bTestStart.UseVisualStyleBackColor = true;
            this.bTestStart.Click += new System.EventHandler(this.bTestStart_Click);
            // 
            // numSetQnum
            // 
            this.numSetQnum.Location = new System.Drawing.Point(193, 76);
            this.numSetQnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSetQnum.Name = "numSetQnum";
            this.numSetQnum.Size = new System.Drawing.Size(63, 20);
            this.numSetQnum.TabIndex = 4;
            this.numSetQnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuestions
            // 
            this.labelQuestions.AutoSize = true;
            this.labelQuestions.Location = new System.Drawing.Point(15, 78);
            this.labelQuestions.Name = "labelQuestions";
            this.labelQuestions.Size = new System.Drawing.Size(85, 13);
            this.labelQuestions.TabIndex = 3;
            this.labelQuestions.Text = "Kérdések száma";
            // 
            // numSetTestTime
            // 
            this.numSetTestTime.Location = new System.Drawing.Point(193, 36);
            this.numSetTestTime.Maximum = new decimal(new int[] {
            3599,
            0,
            0,
            0});
            this.numSetTestTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSetTestTime.Name = "numSetTestTime";
            this.numSetTestTime.Size = new System.Drawing.Size(63, 20);
            this.numSetTestTime.TabIndex = 2;
            this.numSetTestTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // labelTestTime
            // 
            this.labelTestTime.AutoSize = true;
            this.labelTestTime.Location = new System.Drawing.Point(15, 38);
            this.labelTestTime.Name = "labelTestTime";
            this.labelTestTime.Size = new System.Drawing.Size(137, 13);
            this.labelTestTime.TabIndex = 1;
            this.labelTestTime.Text = "Rendelkezésre álló idő (mp)";
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.Controls.Add(this.bEnd);
            this.groupBoxTimer.Controls.Add(this.labelTimer);
            this.groupBoxTimer.Location = new System.Drawing.Point(463, 19);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(152, 128);
            this.groupBoxTimer.TabIndex = 1;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Text = "Hátralévő idő";
            // 
            // bEnd
            // 
            this.bEnd.Location = new System.Drawing.Point(40, 90);
            this.bEnd.Name = "bEnd";
            this.bEnd.Size = new System.Drawing.Size(75, 23);
            this.bEnd.TabIndex = 1;
            this.bEnd.Text = "Befejezés";
            this.bEnd.UseVisualStyleBackColor = true;
            this.bEnd.Click += new System.EventHandler(this.bEnd_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(45, 32);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(61, 24);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "0 : 00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableTest
            // 
            this.tableTest.ColumnCount = 3;
            this.tableTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTest.Location = new System.Drawing.Point(0, 0);
            this.tableTest.Name = "tableTest";
            this.tableTest.RowCount = 1;
            this.tableTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTest.Size = new System.Drawing.Size(578, 143);
            this.tableTest.TabIndex = 2;
            // 
            // panelTableHolder
            // 
            this.panelTableHolder.AutoScroll = true;
            this.panelTableHolder.Controls.Add(this.tableTest);
            this.panelTableHolder.Location = new System.Drawing.Point(37, 233);
            this.panelTableHolder.MinimumSize = new System.Drawing.Size(500, 0);
            this.panelTableHolder.Name = "panelTableHolder";
            this.panelTableHolder.Size = new System.Drawing.Size(578, 143);
            this.panelTableHolder.TabIndex = 3;
            // 
            // TestView
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.panelTableHolder);
            this.Controls.Add(this.groupBoxTimer);
            this.Controls.Add(this.groupBoxTestParam);
            this.Name = "TestView";
            this.Size = new System.Drawing.Size(650, 417);
            this.groupBoxTestParam.ResumeLayout(false);
            this.groupBoxTestParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetQnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetTestTime)).EndInit();
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
            this.panelTableHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        
    }
}

