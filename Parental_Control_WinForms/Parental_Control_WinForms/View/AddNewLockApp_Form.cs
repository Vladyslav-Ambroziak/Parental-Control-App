using Parental_Control_WinForms.Model;
using Parental_Control_WinForms.ModelView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parental_Control_WinForms.View
{
    public partial class AddNewLockApp_Form : Form
    {
        private string PathToIcon = @"C:\Users\elons\OneDrive\Документы\GitHub\Parental-Control-App\Parental_Control_WinForms\Parental_Control_WinForms\Icon\DefaultIconApp.png";
        public AddNewLockApp_Form()
        {
            InitializeComponent();
            this.HourFrom_comboBox1.SelectedIndex = 0;
            this.HourTo_comboBox4.SelectedIndex = 0;
            this.MinuteFrom_comboBox2.SelectedIndex = 0;
            this.MinuteTo_comboBox3.SelectedIndex = 0;
        }
        public AddNewLockApp_Form(string StatusAccount) : this()
        {
            if (StatusAccount == "Base")
            {
                this.TimeWorkApp_panel3.Enabled = false;
            }
        }

        private void Cancel_btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ok_btn2_Click(object sender, EventArgs e)
        {
            using (MyContextDB context = new MyContextDB())
            {
                context.LockedApps.Add(new LockedApp()
                {
                    IconApp = PathToIcon,
                    NameApp = this.NameProg_textBox1.Text,
                    NameProcess = this.NameProc_textBox2.Text,
                    FromTime = new TimeSpan(int.Parse(this.HourFrom_comboBox1.Text), int.Parse(this.MinuteFrom_comboBox2.Text), 0),
                    ToTime = new TimeSpan(int.Parse(this.HourTo_comboBox4.Text), int.Parse(this.MinuteTo_comboBox3.Text), 0),
                    StatusTime = "Off",
                    Status = "On"
                });
                context.SaveChanges();
            }
            this.Close();
        }

        private void ChoiceIcon_btn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogIcon = new OpenFileDialog();
            openFileDialogIcon.Filter = "Image files (*.jpeg, *.png, *.jpg)|*.jpeg;*.png;*.jpg";
            if (openFileDialogIcon.ShowDialog() == DialogResult.OK)
            {
                PathToIcon = openFileDialogIcon.FileName;
                this.IconApp_panel1.BackgroundImage = Image.FromFile(PathToIcon);
            }

        }
    }
}
