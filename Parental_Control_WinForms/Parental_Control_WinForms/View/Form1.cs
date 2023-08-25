using Microsoft.Win32;
using Parental_Control_WinForms.Model;
using Parental_Control_WinForms.ModelView;
using Parental_Control_WinForms.View;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Parental_Control_WinForms
{
    public partial class Form1 : Form
    {
        private Thread th1;
        private ProfileUserControl profile = new ProfileUserControl();
        private AddNewLockApp_Form addNewLockApp;

        int index;
        private bool TurnAccountStatus = true;
        private static bool closeProgram = true;
        public Form1()
        {
            InitializeComponent();

            th1 = new Thread(CheckedLockedProgram);
            profile.textBox1.TextChanged += profile_textBox1_TextChanged;
            profile.Location = new Point(((this.Width + this.menuStrip1.Width) / 2) - (profile.Width / 2), (this.Height / 2) - (profile.Height / 2) - 50);
            profile.Name = "profile_UserControl";
            this.toolStripTextBox1.Text = profile.label6.Text;
        }

        static void CheckedLockedProgram()
        {

            while (closeProgram)
            {
                var prog = Process.GetProcesses();
                using (MyContextDB context = new MyContextDB())
                {
                    foreach (LockedApp item1 in context.LockedApps)
                    {
                        if (item1.Status == "On")
                        {
                            if (item1.StatusTime == "On")
                                if (item1.FromTime.Hours <= DateTime.Now.Hour && item1.FromTime.Minutes <= DateTime.Now.Minute)
                                    foreach (Process proc in prog)
                                    {
                                        if (proc.ProcessName == item1.NameProcess)
                                            proc.Kill();
                                    }
                                else if (item1.ToTime.Hours >= DateTime.Now.Hour && item1.ToTime.Minutes >= DateTime.Now.Minute)
                                    foreach (Process proc in prog)
                                    {
                                        if (proc.ProcessName == item1.NameProcess)
                                            proc.Kill();
                                    }
                        }
                    }
                }
                Thread.Sleep(500);
            }
        }
        private void profile_textBox1_TextChanged(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey myKey = currentUserKey.OpenSubKey("KeyForPremiumAccount");
            if (profile.textBox1.Text == myKey.GetValue("PremiumPass1").ToString())
            {
                profile.label6.Text = "Premium";
                this.toolStripTextBox1.Text = "Premium";
            }
            else
            {
                profile.label6.Text = "Base";
                this.toolStripTextBox1.Text = "Base";
            }
            myKey.Close();
            currentUserKey.Close();
        }
        private void profileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (index != 0)
                while (index != 0)
                    this.Controls.RemoveByKey($"AppUC_{index--}");

            if (this.Controls.Find("profile", true) != null)
                this.Controls.Add(profile);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.Controls.Find("profile", true) != null)
                this.Controls.RemoveByKey("profile_UserControl");
            Conclusion_List_Locked_App();
        }
        private void Conclusion_List_Locked_App()
        {
            int y = 5;
            index = 1;
            using (MyContextDB context = new MyContextDB())
            {
                foreach (LockedApp lockedApp in context.LockedApps)
                {
                    AppUserControl item = new AppUserControl(lockedApp);
                    item.Location = new Point(this.menuStrip1.Width + 5, y);
                    item.Name = $"AppUC_{index++}";
                    item.removeToolStripMenuItem.Click += (e, s) =>
                    {
                        using (MyContextDB context = new MyContextDB())
                        {
                            context.LockedApps.Remove(lockedApp);
                            context.SaveChanges();
                        }
                        if (index != 0)
                            while (index != 0)
                                this.Controls.RemoveByKey($"AppUC_{index--}");
                        Conclusion_List_Locked_App();
                    };
                    if (this.toolStripTextBox1.Text == "Base")
                        item.panel3.Enabled = false;
                    this.Controls.Add(item);
                    y += item.Height + 4;
                }
            }
        }
        private void addLockAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewLockApp = new AddNewLockApp_Form(this.toolStripTextBox1.Text);
            addNewLockApp.FormClosed += (e, s) =>
            {
                if (this.Controls.Find("profile", true) == null)
                    if (index != 0)
                        while (index != 0)
                            this.Controls.RemoveByKey($"AppUC_{index--}");
                Conclusion_List_Locked_App();

            };
            addNewLockApp.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            th1.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeProgram = false;
        }
    }
}