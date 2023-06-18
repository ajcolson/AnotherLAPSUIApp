using AnotherLAPSUIApp.Properties;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Management.Automation;
using System.Security.Principal;

namespace AnotherLAPSUIApp
{
    public partial class MainForm : Form
    {
        public string _UNAME = "Default User";

        public MainForm()
        {
            InitializeComponent();
        }
        private void searchForPassword(string hostname)
        {
            timer1.Stop();
            timer1.Enabled = false;
            searchingLabel.Visible = true;
            hostnameTextBox.Enabled = false;
            searchBtn.Enabled = false;
            passwordTextBox.Text = "";

            if (hostname == null || hostname == "")
            {
                MessageBox.Show("Cannot search for a blank hostname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string password = askDCForPassword(hostname);
                if (password.Contains("get-adcomputer : Cannot find an object with identity:"))
                {
                    MessageBox.Show("There is no computer with the name \"" + hostname + "\" in Baxter AD. Please try a different search.", "Computer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    passwordTextBox.Text = password;
                }
            }

            searchingLabel.Visible = false;
            hostnameTextBox.Enabled = true;
            searchBtn.Enabled = true;
        }
        private string askDCForPassword(string hostname)
        {
            string foundPassword = "";
            string path = Directory.GetCurrentDirectory() + "\\laps-lookup.ps1";
            saveLookupScript(path, hostname);

            try
            {
                var process = new Process();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.FileName = @"powershell.exe";
                process.StartInfo.Arguments = "-ExecutionPolicy Bypass -File \"" + path + "\" --Hostname " + hostname;

                process.Start();
                string s = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                foundPassword = s;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error trying to lookup Baxter password.\n\n\nSource:\n" + e.Source + "\nMessage:\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            removeLookupScript(path);
            return foundPassword;
        }

        private void saveLookupScript(string path, string hostname)
        {

            removeLookupScript(path);
            string script = String.Format(Resources.LookUpScript_ScriptContents, hostname, combineDCNamesFromResources());
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(script);
            sw.Close();
        }

        private string combineDCNamesFromResources()
        {
            string output = "";
            string[] DCs = Resources.DC_NAMES_CSV.Split(',');
            for (int i = 0; i < DCs.Length; i++)
            {
                output += "\"" + DCs[i] + "\"";
                if (i != DCs.Length - 1)
                    output += ",";
            }
            return output;
        }

        private void removeLookupScript(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _UNAME = WindowsIdentity.GetCurrent().Name;
            currentUserLabel.Text = "Current User: " + _UNAME;
        }

        private void hostnameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchingLabel.Visible = true;
                hostnameTextBox.Enabled = false;
                searchBtn.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchingLabel.Visible = true;
            hostnameTextBox.Enabled = false;
            searchBtn.Enabled = false;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            searchForPassword(hostnameTextBox.Text);
        }

        private void copyPwdBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordTextBox.Text);
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            (new AboutForm()).ShowDialog();
        }
    }
}