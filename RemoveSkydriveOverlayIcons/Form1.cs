using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RemoveSkydriveOverlayIcons
{
    public partial class Form1 : Form
    {
        const string userRoot = "HKEY_LOCAL_MACHINE";
        const string subkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ShellIconOverlayIdentifiers\\ SkyDrive1";
        const string keyNameTick = userRoot + "\\" + subkey;
        const string tickAvailable = "{F241C880-6982-4CE5-8CF7-7085BA96DA5A12345}";
        const string tickRemoved = "{_F241C880-6982-4CE5-8CF7-7085BA96DA5A12345}";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = (string)Registry.GetValue(keyNameTick, "","Does not exist");
            listBox1.Items.Add("Current value:");
            listBox1.Items.Add(a);
            if (a.Equals(tickAvailable)) listBox1.Items.Add("=> tick still there");
            else listBox1.Items.Add("=> tick already removed");
        }

        private void buttonRestoreTick_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Restoring tick...");
            Registry.SetValue(keyNameTick, "", tickAvailable);
            listBox1.Items.Add("=> restored tick successfully!");
        }

        private void buttonRemoveTick_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Removing tick...");
            Registry.SetValue(keyNameTick, "", tickRemoved);
            listBox1.Items.Add("=> removed tick successfully!");
        }
    }
}
