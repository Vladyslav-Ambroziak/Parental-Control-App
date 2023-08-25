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
    public partial class AppUserControl : UserControl
    {
        public int index;
        private bool OnOrOffLockedApp = true;
        public AppUserControl()
        {
            InitializeComponent();
        }
        public AppUserControl(LockedApp lockedApp) : this()
        {
            index = lockedApp.Id;
            this.panel2.BackgroundImage = Image.FromFile(lockedApp.IconApp);
            this.Name_app_label1.Text = lockedApp.NameApp;
            this.comboBox1.SelectedIndex = lockedApp.FromTime.Hours;
            this.comboBox2.SelectedIndex = lockedApp.FromTime.Minutes;
            this.comboBox4.SelectedIndex = lockedApp.ToTime.Hours;
            this.comboBox3.SelectedIndex = lockedApp.ToTime.Minutes;
            if (lockedApp.StatusTime == "On")
                this.radioButton1.Checked = true;
            else
                this.radioButton2.Checked = true;
            this.button1.Text = lockedApp.Status;
            if (lockedApp.Status == "On")
                OnOrOffLockedApp = false;
            else
                OnOrOffLockedApp = true;
        }

        private void AppUserControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            using (MyContextDB context = new MyContextDB())
            {
                LockedApp app = context.LockedApps.FirstOrDefault(x => x.Id == index);
                app.StatusTime = this.radioButton1.Text;
                context.SaveChanges();
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            using (MyContextDB context = new MyContextDB())
            {
                LockedApp app = context.LockedApps.FirstOrDefault(x => x.Id == index);
                app.StatusTime = this.radioButton2.Text;
                context.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnOrOffLockedApp)
            {
                this.button1.Text = "On";
                using (MyContextDB context = new MyContextDB())
                {
                    LockedApp app = context.LockedApps.FirstOrDefault(x => x.Id == index);
                    app.Status = this.button1.Text;
                    context.SaveChanges();
                }
                OnOrOffLockedApp = false;
            }
            else
            {
                this.button1.Text = "Off";
                using (MyContextDB context = new MyContextDB())
                {
                    LockedApp app = context.LockedApps.FirstOrDefault(x => x.Id == index);
                    app.Status = this.button1.Text;
                    context.SaveChanges();
                }
                OnOrOffLockedApp = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MyContextDB context = new MyContextDB())
            {
                LockedApp app = context.LockedApps.FirstOrDefault(x => x.Id == index);
                app.FromTime = new TimeSpan(this.comboBox1.SelectedIndex, app.FromTime.Minutes, 0);
                context.SaveChanges();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MyContextDB context = new MyContextDB())
            {
                LockedApp app = context.LockedApps.FirstOrDefault(x => x.Id == index);
                app.FromTime = new TimeSpan(app.FromTime.Hours, this.comboBox2.SelectedIndex, 0);
                context.SaveChanges();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MyContextDB context = new MyContextDB())
            {
                LockedApp app = context.LockedApps.FirstOrDefault(x => x.Id == index);
                app.ToTime = new TimeSpan(this.comboBox4.SelectedIndex, app.ToTime.Minutes, 0);
                context.SaveChanges();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MyContextDB context = new MyContextDB())
            {
                LockedApp app = context.LockedApps.FirstOrDefault(x => x.Id == index);
                app.ToTime = new TimeSpan(app.ToTime.Hours, this.comboBox3.SelectedIndex, 0);
                context.SaveChanges();
            }
        }
    }
}
