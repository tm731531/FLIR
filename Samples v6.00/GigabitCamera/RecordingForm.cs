using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Flir.Atlas.Image;
using Flir.Atlas.Image.Palettes;
using Flir.Atlas.Live.Device;
using Flir.Atlas.Live.WinForms;

namespace GigabitCamera
{
    public partial class RecordingForm : Form
    {
        public RecordingForm()
        {
            InitializeComponent();
        }

        public void SetThermalCamera(ThermalCamera camera)
        {
            recordingControl1.Initialize(camera);
            recordingControl1.SelectedFileMouseDoubleClick += recordingControl1_SelectedFileMouseDoubleClick;
        }

        void recordingControl1_SelectedFileMouseDoubleClick(object sender, SelectedFileEventArgs e)
        {
            var playback = new PlaybackDialog();
            playback.Show();
            playback.Open(e.FilePath);
        }

        private void RecordingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            recordingControl1.UnInitialize();
        }
    }
}
