
using System;

namespace SimpleTimer
{
    partial class SimpleTimer
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
            DateTime now = DateTime.Now;
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleTimer));
            this.StartBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.HHUpDown = new System.Windows.Forms.NumericUpDown();
            this.MMUpDown = new System.Windows.Forms.NumericUpDown();
            this.SSUpDown = new System.Windows.Forms.NumericUpDown();
            this.hh_label = new System.Windows.Forms.Label();
            this.mm_label = new System.Windows.Forms.Label();
            this.ss_label = new System.Windows.Forms.Label();
            this.AddTimerBtn = new System.Windows.Forms.Button();
            this.TimerListView = new System.Windows.Forms.ListView();
            this.job_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hh_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mm_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ss_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveListBtn = new System.Windows.Forms.Button();
            this.ClearListBtn = new System.Windows.Forms.Button();
            this.JobLabel = new System.Windows.Forms.Label();
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.LoopUpDown = new System.Windows.Forms.NumericUpDown();
            this.LoopCountLabel = new System.Windows.Forms.Label();
            this.JobNameBox = new System.Windows.Forms.TextBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.JLabel = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.ClockLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HHUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoopUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartBtn.Location = new System.Drawing.Point(17, 4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(80, 25);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "▶️ Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PauseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PauseBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PauseBtn.Location = new System.Drawing.Point(155, 4);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(80, 25);
            this.PauseBtn.TabIndex = 1;
            this.PauseBtn.Text = "⏸️ Pause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResetBtn.Location = new System.Drawing.Point(298, 4);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(80, 25);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "🔄 Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // HHUpDown
            // 
            this.HHUpDown.Location = new System.Drawing.Point(160, 9);
            this.HHUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HHUpDown.Name = "HHUpDown";
            this.HHUpDown.Size = new System.Drawing.Size(40, 20);
            this.HHUpDown.TabIndex = 12;
            // 
            // MMUpDown
            // 
            this.MMUpDown.Location = new System.Drawing.Point(226, 9);
            this.MMUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MMUpDown.Name = "MMUpDown";
            this.MMUpDown.Size = new System.Drawing.Size(40, 20);
            this.MMUpDown.TabIndex = 13;
            // 
            // SSUpDown
            // 
            this.SSUpDown.Location = new System.Drawing.Point(296, 9);
            this.SSUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SSUpDown.Name = "SSUpDown";
            this.SSUpDown.Size = new System.Drawing.Size(40, 20);
            this.SSUpDown.TabIndex = 14;
            // 
            // hh_label
            // 
            this.hh_label.AutoSize = true;
            this.hh_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hh_label.Location = new System.Drawing.Point(201, 12);
            this.hh_label.Name = "hh_label";
            this.hh_label.Size = new System.Drawing.Size(19, 13);
            this.hh_label.TabIndex = 15;
            this.hh_label.Text = "hh";
            // 
            // mm_label
            // 
            this.mm_label.AutoSize = true;
            this.mm_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mm_label.Location = new System.Drawing.Point(266, 11);
            this.mm_label.Name = "mm_label";
            this.mm_label.Size = new System.Drawing.Size(23, 13);
            this.mm_label.TabIndex = 16;
            this.mm_label.Text = "mm";
            // 
            // ss_label
            // 
            this.ss_label.AutoSize = true;
            this.ss_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ss_label.Location = new System.Drawing.Point(336, 11);
            this.ss_label.Name = "ss_label";
            this.ss_label.Size = new System.Drawing.Size(17, 13);
            this.ss_label.TabIndex = 17;
            this.ss_label.Text = "ss";
            // 
            // AddTimerBtn
            // 
            this.AddTimerBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddTimerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddTimerBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTimerBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AddTimerBtn.Location = new System.Drawing.Point(296, 41);
            this.AddTimerBtn.Name = "AddTimerBtn";
            this.AddTimerBtn.Size = new System.Drawing.Size(57, 23);
            this.AddTimerBtn.TabIndex = 19;
            this.AddTimerBtn.Text = "Add";
            this.AddTimerBtn.UseVisualStyleBackColor = false;
            this.AddTimerBtn.Click += new System.EventHandler(this.AddTimerBtn_Click);
            // 
            // TimerListView
            // 
            this.TimerListView.AllowColumnReorder = true;
            this.TimerListView.AllowDrop = true;
            this.TimerListView.AutoArrange = false;
            this.TimerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.job_column,
            this.hh_column,
            this.mm_column,
            this.ss_column});
            this.TimerListView.FullRowSelect = true;
            this.TimerListView.GridLines = true;
            this.TimerListView.HideSelection = false;
            this.TimerListView.Location = new System.Drawing.Point(7, 41);
            this.TimerListView.Name = "TimerListView";
            this.TimerListView.Size = new System.Drawing.Size(277, 100);
            this.TimerListView.TabIndex = 20;
            this.TimerListView.UseCompatibleStateImageBehavior = false;
            this.TimerListView.View = System.Windows.Forms.View.Details;
            // 
            // job_column
            // 
            this.job_column.Text = "Job Name";
            // 
            // hh_column
            // 
            this.hh_column.Text = "hh";
            // 
            // mm_column
            // 
            this.mm_column.Text = "mm";
            // 
            // ss_column
            // 
            this.ss_column.Text = "ss";
            // 
            // RemoveListBtn
            // 
            this.RemoveListBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RemoveListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveListBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveListBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.RemoveListBtn.Location = new System.Drawing.Point(296, 80);
            this.RemoveListBtn.Name = "RemoveListBtn";
            this.RemoveListBtn.Size = new System.Drawing.Size(57, 23);
            this.RemoveListBtn.TabIndex = 21;
            this.RemoveListBtn.Text = "Remove";
            this.RemoveListBtn.UseVisualStyleBackColor = false;
            this.RemoveListBtn.Click += new System.EventHandler(this.RemoveTimerBtn_Click);
            // 
            // ClearListBtn
            // 
            this.ClearListBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClearListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearListBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearListBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ClearListBtn.Location = new System.Drawing.Point(296, 118);
            this.ClearListBtn.Name = "ClearListBtn";
            this.ClearListBtn.Size = new System.Drawing.Size(57, 23);
            this.ClearListBtn.TabIndex = 22;
            this.ClearListBtn.Text = "🧹Clear";
            this.ClearListBtn.UseVisualStyleBackColor = false;
            this.ClearListBtn.Click += new System.EventHandler(this.ClearListBtn_Click);
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobLabel.ForeColor = System.Drawing.Color.DimGray;
            this.JobLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.JobLabel.Location = new System.Drawing.Point(15, 15);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(55, 30);
            this.JobLabel.TabIndex = 23;
            this.JobLabel.Text = "Job";
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.LoopCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoopCheckBox.Location = new System.Drawing.Point(19, 39);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(81, 17);
            this.LoopCheckBox.TabIndex = 24;
            this.LoopCheckBox.Text = "Loop Count";
            this.LoopCheckBox.UseVisualStyleBackColor = false;
            this.LoopCheckBox.CheckedChanged += new System.EventHandler(this.LoopCheckBox_CheckedChanged);
            // 
            // LoopUpDown
            // 
            this.LoopUpDown.Enabled = false;
            this.LoopUpDown.Location = new System.Drawing.Point(106, 36);
            this.LoopUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LoopUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LoopUpDown.Name = "LoopUpDown";
            this.LoopUpDown.Size = new System.Drawing.Size(60, 20);
            this.LoopUpDown.TabIndex = 25;
            this.LoopUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LoopUpDown.ValueChanged += new System.EventHandler(this.LoopUpDown_ValueChanged);
            // 
            // LoopCountLabel
            // 
            this.LoopCountLabel.AutoSize = true;
            this.LoopCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoopCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoopCountLabel.Location = new System.Drawing.Point(172, 40);
            this.LoopCountLabel.Name = "LoopCountLabel";
            this.LoopCountLabel.Size = new System.Drawing.Size(63, 13);
            this.LoopCountLabel.TabIndex = 26;
            this.LoopCountLabel.Text = "Loop left : 1";
            // 
            // JobNameBox
            // 
            this.JobNameBox.Location = new System.Drawing.Point(60, 9);
            this.JobNameBox.Name = "JobNameBox";
            this.JobNameBox.Size = new System.Drawing.Size(80, 20);
            this.JobNameBox.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.StartTimeLabel);
            this.panel1.Controls.Add(this.StartTimePicker);
            this.panel1.Controls.Add(this.StartTimeCheckBox);
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Controls.Add(this.PauseBtn);
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.LoopCountLabel);
            this.panel1.Controls.Add(this.LoopCheckBox);
            this.panel1.Controls.Add(this.LoopUpDown);
            this.panel1.Location = new System.Drawing.Point(-5, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 86);
            this.panel1.TabIndex = 29;
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartTimeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartTimeLabel.Location = new System.Drawing.Point(172, 62);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(61, 13);
            this.StartTimeLabel.TabIndex = 29;
            this.StartTimeLabel.Text = "00 : 00 : 00";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "HH:mm:ss";
            this.StartTimePicker.Enabled = false;
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(83, 59);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(83, 20);
            this.StartTimePicker.TabIndex = 28;
            this.StartTimePicker.Value = new System.DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
            // 
            // StartTimeCheckBox
            // 
            this.StartTimeCheckBox.AutoSize = true;
            this.StartTimeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.StartTimeCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartTimeCheckBox.Location = new System.Drawing.Point(19, 62);
            this.StartTimeCheckBox.Name = "StartTimeCheckBox";
            this.StartTimeCheckBox.Size = new System.Drawing.Size(61, 17);
            this.StartTimeCheckBox.TabIndex = 27;
            this.StartTimeCheckBox.Text = "Start At";
            this.StartTimeCheckBox.UseVisualStyleBackColor = false;
            this.StartTimeCheckBox.CheckedChanged += new System.EventHandler(this.StartTimeCheckBox_CheckedChanged);
            // 
            // TimerLabel
            // 
            this.TimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TimerLabel.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TimerLabel.Location = new System.Drawing.Point(12, 45);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(361, 76);
            this.TimerLabel.TabIndex = 8;
            this.TimerLabel.Text = "00 : 00 : 00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.JLabel);
            this.panel2.Controls.Add(this.JobNameBox);
            this.panel2.Controls.Add(this.HHUpDown);
            this.panel2.Controls.Add(this.ClearListBtn);
            this.panel2.Controls.Add(this.RemoveListBtn);
            this.panel2.Controls.Add(this.hh_label);
            this.panel2.Controls.Add(this.AddTimerBtn);
            this.panel2.Controls.Add(this.MMUpDown);
            this.panel2.Controls.Add(this.TimerListView);
            this.panel2.Controls.Add(this.mm_label);
            this.panel2.Controls.Add(this.SSUpDown);
            this.panel2.Controls.Add(this.ss_label);
            this.panel2.Location = new System.Drawing.Point(12, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 151);
            this.panel2.TabIndex = 30;
            // 
            // JLabel
            // 
            this.JLabel.AutoSize = true;
            this.JLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JLabel.Location = new System.Drawing.Point(5, 13);
            this.JLabel.Name = "JLabel";
            this.JLabel.Size = new System.Drawing.Size(53, 13);
            this.JLabel.TabIndex = 29;
            this.JLabel.Text = "Job name";
            // 
            // Clock
            // 
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // ClockLable
            // 
            this.ClockLable.AutoSize = true;
            this.ClockLable.Location = new System.Drawing.Point(318, 28);
            this.ClockLable.Name = "ClockLable";
            this.ClockLable.Size = new System.Drawing.Size(61, 13);
            this.ClockLable.TabIndex = 31;
            // 
            // SimpleTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.ClockLable);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleTimer";
            this.Text = "SimpleTimer";
            this.Load += new System.EventHandler(this.SimpleTimer_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTimerBtn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.HHUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoopUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.NumericUpDown HHUpDown;
        private System.Windows.Forms.NumericUpDown MMUpDown;
        private System.Windows.Forms.NumericUpDown SSUpDown;
        private System.Windows.Forms.Label hh_label;
        private System.Windows.Forms.Label mm_label;
        private System.Windows.Forms.Label ss_label;
        private System.Windows.Forms.Button AddTimerBtn;
        private System.Windows.Forms.ListView TimerListView;
        private System.Windows.Forms.ColumnHeader hh_column;
        private System.Windows.Forms.ColumnHeader mm_column;
        private System.Windows.Forms.ColumnHeader ss_column;
        private System.Windows.Forms.ColumnHeader job_column;
        private System.Windows.Forms.Button RemoveListBtn;
        private System.Windows.Forms.Button ClearListBtn;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.CheckBox LoopCheckBox;
        private System.Windows.Forms.NumericUpDown LoopUpDown;
        private System.Windows.Forms.Label LoopCountLabel;
        private System.Windows.Forms.TextBox JobNameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label JLabel;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label ClockLable;
        private System.Windows.Forms.CheckBox StartTimeCheckBox;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label StartTimeLabel;
    }
}

