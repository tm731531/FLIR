using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Flir.Atlas.Live.Device;
using Flir.Atlas.Live.WinForms;

namespace IP_Config
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static bool CheckCompatibility()
        {
            var ver = CameraBase.Version.Split('.');
            if (ver.Count() <= 3) return false;
            int major, minor, rev;
            if (!int.TryParse(ver[0], out major))
            {
                return false;
            }
            if (!int.TryParse(ver[1], out minor))
            {
                return false;
            }
            if (!int.TryParse(ver[2], out rev))
            {
                return false;
            }
            return major >= 3 && (major != 3 || rev > 15162);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = "IP Config sample, running Atlas version: " + CameraBase.Version;

            if (!CheckCompatibility())
            {
                MessageBox.Show("Atlas version is not compatible. Update Atlas to latest.", "Error");
                Close();
            }
            discoveryControl1.SelectionChanged += discoveryControl1_SelectionChanged;
            discoveryControl1.MouseDoubleClickEvent += discoveryControl1_MouseDoubleClickEvent;
            discoveryControl1.Start();
        }

        void discoveryControl1_MouseDoubleClickEvent(object sender, EventArgs e)
        {
            if (discoveryControl1.SelectedCameraDeviceInfo != null &&
                discoveryControl1.SelectedCameraDeviceInfo.IpConfiguration != null)
            {
                var dlg = new CameraSettingsForm(discoveryControl1.SelectedCameraDeviceInfo);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ThreadPool.QueueUserWorkItem(RefreshDiscovery, discoveryControl1);
                }
            }
        }

        void discoveryControl1_SelectionChanged(object sender, EventArgs e)
        {
            if (discoveryControl1.SelectedCameraDeviceInfo != null && discoveryControl1.SelectedCameraDeviceInfo.IpConfiguration != null)
            {
                btnSettings.Enabled = true;
                optionsToolStripMenuItem.Enabled = true;
                btnWeb.Enabled = true;
            }
            else
            {
                btnSettings.Enabled = false;
                optionsToolStripMenuItem.Enabled = false;
                btnWeb.Enabled = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            discoveryControl1.Stop();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            if (discoveryControl1.SelectedCameraDeviceInfo != null &&
                discoveryControl1.SelectedCameraDeviceInfo.IpSettings != null)
            {
                Process.Start(@"http://" + discoveryControl1.SelectedCameraDeviceInfo.IpSettings.IpAddress);    
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(RefreshDiscovery, discoveryControl1);
        }

        static void RefreshDiscovery(Object context)
        {
            var ctrl = (DiscoveryControl) context;
            ctrl.Refresh();
        }
    }
}
