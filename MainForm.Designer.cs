namespace AnotherLAPSUIApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            currentUserLabel = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            searchBtn = new Button();
            hostnameTextBox = new TextBox();
            searchingLabel = new Label();
            groupBox2 = new GroupBox();
            copyPwdBtn = new Button();
            passwordTextBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            AboutBtn = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(currentUserLabel);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 34);
            panel1.TabIndex = 0;
            // 
            // currentUserLabel
            // 
            currentUserLabel.AutoSize = true;
            currentUserLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            currentUserLabel.ForeColor = SystemColors.HighlightText;
            currentUserLabel.Location = new Point(10, 5);
            currentUserLabel.Name = "currentUserLabel";
            currentUserLabel.Size = new Size(102, 21);
            currentUserLabel.TabIndex = 0;
            currentUserLabel.Text = "Current User:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 252);
            label3.Name = "label3";
            label3.Size = new Size(280, 15);
            label3.TabIndex = 2;
            label3.Text = "Copyright 2023 Alex Colson <hello@ajcolson.com>";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(hostnameTextBox);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 46);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(486, 90);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hostname";
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.Location = new Point(380, 38);
            searchBtn.Margin = new Padding(3, 2, 3, 2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(100, 32);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // hostnameTextBox
            // 
            hostnameTextBox.Location = new Point(14, 38);
            hostnameTextBox.Margin = new Padding(3, 2, 3, 2);
            hostnameTextBox.Name = "hostnameTextBox";
            hostnameTextBox.Size = new Size(360, 32);
            hostnameTextBox.TabIndex = 0;
            hostnameTextBox.KeyDown += hostnameTextBox_KeyDown;
            // 
            // searchingLabel
            // 
            searchingLabel.AutoSize = true;
            searchingLabel.BackColor = SystemColors.ButtonFace;
            searchingLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchingLabel.ForeColor = SystemColors.HotTrack;
            searchingLabel.Location = new Point(18, 37);
            searchingLabel.Name = "searchingLabel";
            searchingLabel.Size = new Size(199, 25);
            searchingLabel.TabIndex = 6;
            searchingLabel.Text = "Searching right now ...";
            searchingLabel.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(copyPwdBtn);
            groupBox2.Controls.Add(searchingLabel);
            groupBox2.Controls.Add(passwordTextBox);
            groupBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(10, 151);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(486, 78);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Password";
            // 
            // copyPwdBtn
            // 
            copyPwdBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            copyPwdBtn.Location = new Point(380, 34);
            copyPwdBtn.Margin = new Padding(3, 2, 3, 2);
            copyPwdBtn.Name = "copyPwdBtn";
            copyPwdBtn.Size = new Size(100, 32);
            copyPwdBtn.TabIndex = 7;
            copyPwdBtn.Text = "Copy";
            copyPwdBtn.UseVisualStyleBackColor = true;
            copyPwdBtn.Click += copyPwdBtn_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(14, 34);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.ReadOnly = true;
            passwordTextBox.Size = new Size(360, 32);
            passwordTextBox.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // AboutBtn
            // 
            AboutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AboutBtn.Location = new Point(10, 241);
            AboutBtn.Margin = new Padding(3, 2, 3, 2);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.Size = new Size(100, 32);
            AboutBtn.TabIndex = 8;
            AboutBtn.Text = "About";
            AboutBtn.UseVisualStyleBackColor = true;
            AboutBtn.Click += AboutBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(507, 284);
            Controls.Add(AboutBtn);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Another LAPS UI App";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label currentUserLabel;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox hostnameTextBox;
        private GroupBox groupBox2;
        private TextBox passwordTextBox;
        private Button searchBtn;
        private Label searchingLabel;
        private System.Windows.Forms.Timer timer1;
        private Button copyPwdBtn;
        private Button AboutBtn;
    }
}