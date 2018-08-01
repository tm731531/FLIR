using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Flir.Atlas.Live.Discovery;

namespace IP_Config
{
    public partial class CameraSettingsForm : Form
    {
        private readonly CameraDeviceInfo _device;

        public CameraSettingsForm(CameraDeviceInfo device)
        {
            _device = device;
            InitializeComponent();

            
        }

        private void CameraSettingsForm_Load(object sender, EventArgs e)
        {
            ipConfigControl1.IpSettingsChanged += ipConfigControl1_IpSettingsChanged;
            ipConfigControl1.Initialize(_device);
        }

        void ipConfigControl1_IpSettingsChanged(object sender, Flir.Atlas.Live.WinForms.IpSettingsChangedEventArgs e)
        {
            DialogResult = e.Result;
            Close();
        }

        
    }
}
