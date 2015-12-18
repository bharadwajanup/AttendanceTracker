namespace AttendanceTracker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkInTextBox = new System.Windows.Forms.TextBox();
            this.checkOutTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numberOfHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.todayTab = new System.Windows.Forms.TabPage();
            this.thisWeekTab = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.todayTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "You can access it anytime by double clicking this icon";
            this.notifyIcon1.BalloonTipTitle = "Application is still running.";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Attendance Tracker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check-In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Check-Out";
            // 
            // checkInTextBox
            // 
            this.checkInTextBox.Location = new System.Drawing.Point(111, 68);
            this.checkInTextBox.Name = "checkInTextBox";
            this.checkInTextBox.ReadOnly = true;
            this.checkInTextBox.Size = new System.Drawing.Size(111, 20);
            this.checkInTextBox.TabIndex = 3;
            // 
            // checkOutTextBox
            // 
            this.checkOutTextBox.Location = new System.Drawing.Point(111, 105);
            this.checkOutTextBox.Name = "checkOutTextBox";
            this.checkOutTextBox.ReadOnly = true;
            this.checkOutTextBox.Size = new System.Drawing.Size(111, 20);
            this.checkOutTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberOfHours
            // 
            this.numberOfHours.Location = new System.Drawing.Point(401, 65);
            this.numberOfHours.Name = "numberOfHours";
            this.numberOfHours.ReadOnly = true;
            this.numberOfHours.Size = new System.Drawing.Size(78, 20);
            this.numberOfHours.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of Hours(HH:mm)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.todayTab);
            this.tabControl1.Controls.Add(this.thisWeekTab);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 215);
            this.tabControl1.TabIndex = 9;
            // 
            // todayTab
            // 
            this.todayTab.Controls.Add(this.numberOfHours);
            this.todayTab.Controls.Add(this.label4);
            this.todayTab.Controls.Add(this.dateTimePicker1);
            this.todayTab.Controls.Add(this.label1);
            this.todayTab.Controls.Add(this.label2);
            this.todayTab.Controls.Add(this.button1);
            this.todayTab.Controls.Add(this.checkInTextBox);
            this.todayTab.Controls.Add(this.checkOutTextBox);
            this.todayTab.Location = new System.Drawing.Point(4, 22);
            this.todayTab.Name = "todayTab";
            this.todayTab.Padding = new System.Windows.Forms.Padding(3);
            this.todayTab.Size = new System.Drawing.Size(534, 189);
            this.todayTab.TabIndex = 0;
            this.todayTab.Text = "Today";
            this.todayTab.UseVisualStyleBackColor = true;
            // 
            // thisWeekTab
            // 
            this.thisWeekTab.Location = new System.Drawing.Point(4, 22);
            this.thisWeekTab.Name = "thisWeekTab";
            this.thisWeekTab.Padding = new System.Windows.Forms.Padding(3);
            this.thisWeekTab.Size = new System.Drawing.Size(534, 189);
            this.thisWeekTab.TabIndex = 1;
            this.thisWeekTab.Text = "This Week";
            this.thisWeekTab.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 219);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Attendance Tracker";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.todayTab.ResumeLayout(false);
            this.todayTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox checkInTextBox;
        private System.Windows.Forms.TextBox checkOutTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numberOfHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage todayTab;
        private System.Windows.Forms.TabPage thisWeekTab;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

