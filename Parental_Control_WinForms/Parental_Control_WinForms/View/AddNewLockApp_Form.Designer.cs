namespace Parental_Control_WinForms.View
{
    partial class AddNewLockApp_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewLockApp_Form));
            IconApp_panel1 = new Panel();
            ChoiceIcon_btn1 = new Button();
            NameProgProc_panel2 = new Panel();
            NameProc_textBox2 = new TextBox();
            NameProcess_label2 = new Label();
            NameProg_textBox1 = new TextBox();
            NameProgram_label1 = new Label();
            TimeWorkApp_panel3 = new Panel();
            label9 = new Label();
            MinuteTo_comboBox3 = new ComboBox();
            HourTo_comboBox4 = new ComboBox();
            MinuteTo_label10 = new Label();
            HourTo_label11 = new Label();
            TextTo_label5 = new Label();
            TimeWorkAppTitle_label3 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            MinuteFrom_comboBox2 = new ComboBox();
            HourFrom_comboBox1 = new ComboBox();
            MinuteFrom_label7 = new Label();
            HoutFrom_label6 = new Label();
            TexdtFrom_label4 = new Label();
            Ok_btn2 = new Button();
            Cancel_btn3 = new Button();
            NameProgProc_panel2.SuspendLayout();
            TimeWorkApp_panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // IconApp_panel1
            // 
            IconApp_panel1.BackColor = Color.White;
            IconApp_panel1.BackgroundImage = (Image)resources.GetObject("IconApp_panel1.BackgroundImage");
            IconApp_panel1.BackgroundImageLayout = ImageLayout.Stretch;
            IconApp_panel1.BorderStyle = BorderStyle.FixedSingle;
            IconApp_panel1.Location = new Point(12, 12);
            IconApp_panel1.Name = "IconApp_panel1";
            IconApp_panel1.Size = new Size(127, 127);
            IconApp_panel1.TabIndex = 0;
            // 
            // ChoiceIcon_btn1
            // 
            ChoiceIcon_btn1.BackColor = Color.FromArgb(28, 118, 143);
            ChoiceIcon_btn1.FlatStyle = FlatStyle.Flat;
            ChoiceIcon_btn1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ChoiceIcon_btn1.ForeColor = SystemColors.ControlLightLight;
            ChoiceIcon_btn1.Location = new Point(12, 155);
            ChoiceIcon_btn1.Name = "ChoiceIcon_btn1";
            ChoiceIcon_btn1.Size = new Size(127, 36);
            ChoiceIcon_btn1.TabIndex = 1;
            ChoiceIcon_btn1.Text = "Choice icon app";
            ChoiceIcon_btn1.UseVisualStyleBackColor = false;
            ChoiceIcon_btn1.Click += ChoiceIcon_btn1_Click;
            // 
            // NameProgProc_panel2
            // 
            NameProgProc_panel2.BackColor = Color.FromArgb(250, 153, 28);
            NameProgProc_panel2.Controls.Add(NameProc_textBox2);
            NameProgProc_panel2.Controls.Add(NameProcess_label2);
            NameProgProc_panel2.Controls.Add(NameProg_textBox1);
            NameProgProc_panel2.Controls.Add(NameProgram_label1);
            NameProgProc_panel2.Location = new Point(160, 12);
            NameProgProc_panel2.Name = "NameProgProc_panel2";
            NameProgProc_panel2.Size = new Size(229, 179);
            NameProgProc_panel2.TabIndex = 2;
            // 
            // NameProc_textBox2
            // 
            NameProc_textBox2.Location = new Point(28, 130);
            NameProc_textBox2.Name = "NameProc_textBox2";
            NameProc_textBox2.Size = new Size(181, 23);
            NameProc_textBox2.TabIndex = 3;
            // 
            // NameProcess_label2
            // 
            NameProcess_label2.AutoSize = true;
            NameProcess_label2.Font = new Font("Yu Gothic UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            NameProcess_label2.ForeColor = SystemColors.ControlLightLight;
            NameProcess_label2.Location = new Point(14, 98);
            NameProcess_label2.Name = "NameProcess_label2";
            NameProcess_label2.Size = new Size(152, 20);
            NameProcess_label2.TabIndex = 2;
            NameProcess_label2.Text = "Name process (must)";
            // 
            // NameProg_textBox1
            // 
            NameProg_textBox1.Location = new Point(28, 49);
            NameProg_textBox1.Name = "NameProg_textBox1";
            NameProg_textBox1.Size = new Size(181, 23);
            NameProg_textBox1.TabIndex = 1;
            // 
            // NameProgram_label1
            // 
            NameProgram_label1.AutoSize = true;
            NameProgram_label1.Font = new Font("Yu Gothic UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            NameProgram_label1.ForeColor = SystemColors.ControlLightLight;
            NameProgram_label1.Location = new Point(14, 17);
            NameProgram_label1.Name = "NameProgram_label1";
            NameProgram_label1.Size = new Size(114, 20);
            NameProgram_label1.TabIndex = 0;
            NameProgram_label1.Text = "Name program";
            // 
            // TimeWorkApp_panel3
            // 
            TimeWorkApp_panel3.BackColor = Color.FromArgb(3, 37, 57);
            TimeWorkApp_panel3.Controls.Add(label9);
            TimeWorkApp_panel3.Controls.Add(MinuteTo_comboBox3);
            TimeWorkApp_panel3.Controls.Add(HourTo_comboBox4);
            TimeWorkApp_panel3.Controls.Add(MinuteTo_label10);
            TimeWorkApp_panel3.Controls.Add(HourTo_label11);
            TimeWorkApp_panel3.Controls.Add(TextTo_label5);
            TimeWorkApp_panel3.Controls.Add(TimeWorkAppTitle_label3);
            TimeWorkApp_panel3.Controls.Add(panel4);
            TimeWorkApp_panel3.Location = new Point(12, 212);
            TimeWorkApp_panel3.Name = "TimeWorkApp_panel3";
            TimeWorkApp_panel3.Size = new Size(377, 148);
            TimeWorkApp_panel3.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(277, 96);
            label9.Name = "label9";
            label9.Size = new Size(17, 25);
            label9.TabIndex = 10;
            label9.Text = ":";
            // 
            // MinuteTo_comboBox3
            // 
            MinuteTo_comboBox3.FormattingEnabled = true;
            MinuteTo_comboBox3.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            MinuteTo_comboBox3.Location = new Point(298, 100);
            MinuteTo_comboBox3.Name = "MinuteTo_comboBox3";
            MinuteTo_comboBox3.Size = new Size(52, 23);
            MinuteTo_comboBox3.TabIndex = 9;
            // 
            // HourTo_comboBox4
            // 
            HourTo_comboBox4.FormattingEnabled = true;
            HourTo_comboBox4.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            HourTo_comboBox4.Location = new Point(217, 100);
            HourTo_comboBox4.Name = "HourTo_comboBox4";
            HourTo_comboBox4.Size = new Size(52, 23);
            HourTo_comboBox4.TabIndex = 8;
            // 
            // MinuteTo_label10
            // 
            MinuteTo_label10.AutoSize = true;
            MinuteTo_label10.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MinuteTo_label10.ForeColor = SystemColors.ControlLightLight;
            MinuteTo_label10.Location = new Point(302, 82);
            MinuteTo_label10.Name = "MinuteTo_label10";
            MinuteTo_label10.Size = new Size(45, 15);
            MinuteTo_label10.TabIndex = 7;
            MinuteTo_label10.Text = "minute";
            // 
            // HourTo_label11
            // 
            HourTo_label11.AutoSize = true;
            HourTo_label11.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HourTo_label11.ForeColor = SystemColors.ControlLightLight;
            HourTo_label11.Location = new Point(228, 82);
            HourTo_label11.Name = "HourTo_label11";
            HourTo_label11.Size = new Size(32, 15);
            HourTo_label11.TabIndex = 6;
            HourTo_label11.Text = "hour";
            // 
            // TextTo_label5
            // 
            TextTo_label5.AutoSize = true;
            TextTo_label5.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextTo_label5.ForeColor = SystemColors.ControlLightLight;
            TextTo_label5.Location = new Point(210, 53);
            TextTo_label5.Name = "TextTo_label5";
            TextTo_label5.Size = new Size(24, 20);
            TextTo_label5.TabIndex = 2;
            TextTo_label5.Text = "To";
            // 
            // TimeWorkAppTitle_label3
            // 
            TimeWorkAppTitle_label3.AutoSize = true;
            TimeWorkAppTitle_label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TimeWorkAppTitle_label3.ForeColor = SystemColors.ControlLightLight;
            TimeWorkAppTitle_label3.Location = new Point(128, 9);
            TimeWorkAppTitle_label3.Name = "TimeWorkAppTitle_label3";
            TimeWorkAppTitle_label3.Size = new Size(118, 21);
            TimeWorkAppTitle_label3.TabIndex = 1;
            TimeWorkAppTitle_label3.Text = "Time work app";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(251, 243, 242);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(MinuteFrom_comboBox2);
            panel4.Controls.Add(HourFrom_comboBox1);
            panel4.Controls.Add(MinuteFrom_label7);
            panel4.Controls.Add(HoutFrom_label6);
            panel4.Controls.Add(TexdtFrom_label4);
            panel4.Location = new Point(13, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(182, 92);
            panel4.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(81, 54);
            label8.Name = "label8";
            label8.Size = new Size(17, 25);
            label8.TabIndex = 5;
            label8.Text = ":";
            // 
            // MinuteFrom_comboBox2
            // 
            MinuteFrom_comboBox2.FormattingEnabled = true;
            MinuteFrom_comboBox2.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            MinuteFrom_comboBox2.Location = new Point(102, 58);
            MinuteFrom_comboBox2.Name = "MinuteFrom_comboBox2";
            MinuteFrom_comboBox2.Size = new Size(52, 23);
            MinuteFrom_comboBox2.TabIndex = 4;
            // 
            // HourFrom_comboBox1
            // 
            HourFrom_comboBox1.FormattingEnabled = true;
            HourFrom_comboBox1.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            HourFrom_comboBox1.Location = new Point(21, 58);
            HourFrom_comboBox1.Name = "HourFrom_comboBox1";
            HourFrom_comboBox1.Size = new Size(52, 23);
            HourFrom_comboBox1.TabIndex = 3;
            // 
            // MinuteFrom_label7
            // 
            MinuteFrom_label7.AutoSize = true;
            MinuteFrom_label7.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MinuteFrom_label7.Location = new Point(106, 40);
            MinuteFrom_label7.Name = "MinuteFrom_label7";
            MinuteFrom_label7.Size = new Size(45, 15);
            MinuteFrom_label7.TabIndex = 2;
            MinuteFrom_label7.Text = "minute";
            // 
            // HoutFrom_label6
            // 
            HoutFrom_label6.AutoSize = true;
            HoutFrom_label6.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HoutFrom_label6.Location = new Point(32, 40);
            HoutFrom_label6.Name = "HoutFrom_label6";
            HoutFrom_label6.Size = new Size(32, 15);
            HoutFrom_label6.TabIndex = 1;
            HoutFrom_label6.Text = "hour";
            // 
            // TexdtFrom_label4
            // 
            TexdtFrom_label4.AutoSize = true;
            TexdtFrom_label4.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TexdtFrom_label4.Location = new Point(12, 11);
            TexdtFrom_label4.Name = "TexdtFrom_label4";
            TexdtFrom_label4.Size = new Size(44, 20);
            TexdtFrom_label4.TabIndex = 0;
            TexdtFrom_label4.Text = "From";
            // 
            // Ok_btn2
            // 
            Ok_btn2.BackColor = Color.FromArgb(28, 118, 143);
            Ok_btn2.FlatStyle = FlatStyle.Flat;
            Ok_btn2.ForeColor = SystemColors.ControlLightLight;
            Ok_btn2.Location = new Point(25, 386);
            Ok_btn2.Name = "Ok_btn2";
            Ok_btn2.Size = new Size(114, 37);
            Ok_btn2.TabIndex = 4;
            Ok_btn2.Text = "Ok";
            Ok_btn2.UseVisualStyleBackColor = false;
            Ok_btn2.Click += Ok_btn2_Click;
            // 
            // Cancel_btn3
            // 
            Cancel_btn3.BackColor = Color.FromArgb(28, 118, 143);
            Cancel_btn3.FlatStyle = FlatStyle.Flat;
            Cancel_btn3.ForeColor = SystemColors.ControlLightLight;
            Cancel_btn3.Location = new Point(255, 386);
            Cancel_btn3.Name = "Cancel_btn3";
            Cancel_btn3.Size = new Size(114, 37);
            Cancel_btn3.TabIndex = 5;
            Cancel_btn3.Text = "Cancel";
            Cancel_btn3.UseVisualStyleBackColor = false;
            Cancel_btn3.Click += Cancel_btn3_Click;
            // 
            // AddNewLockApp_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 242);
            ClientSize = new Size(404, 438);
            Controls.Add(Cancel_btn3);
            Controls.Add(Ok_btn2);
            Controls.Add(TimeWorkApp_panel3);
            Controls.Add(NameProgProc_panel2);
            Controls.Add(ChoiceIcon_btn1);
            Controls.Add(IconApp_panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddNewLockApp_Form";
            Text = "Add new lock app";
            NameProgProc_panel2.ResumeLayout(false);
            NameProgProc_panel2.PerformLayout();
            TimeWorkApp_panel3.ResumeLayout(false);
            TimeWorkApp_panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel IconApp_panel1;
        private Button ChoiceIcon_btn1;
        private Panel NameProgProc_panel2;
        private Label NameProgram_label1;
        private Panel TimeWorkApp_panel3;
        private Button Ok_btn2;
        private Button Cancel_btn3;
        private TextBox NameProc_textBox2;
        private Label NameProcess_label2;
        private TextBox NameProg_textBox1;
        private Panel panel4;
        private Label TextTo_label5;
        private Label TimeWorkAppTitle_label3;
        private Label MinuteFrom_label7;
        private Label HoutFrom_label6;
        private Label TexdtFrom_label4;
        private ComboBox HourFrom_comboBox1;
        private Label label9;
        private ComboBox MinuteTo_comboBox3;
        private ComboBox HourTo_comboBox4;
        private Label MinuteTo_label10;
        private Label HourTo_label11;
        private Label label8;
        private ComboBox MinuteFrom_comboBox2;
    }
}