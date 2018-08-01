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

namespace GigabitCamera
{
    public partial class PlaybackDialog : Form
    {
        public PlaybackDialog()
        {
            InitializeComponent();
        }


        private void PlaybackDialog_Load(object sender, EventArgs e)
        {

        }

        private void PlaybackDialog_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        internal void Open(string path)
        {
            try
            {
                var img = new ThermalImageFile(path) { Palette = PaletteManager.Iron };
                thermalImageControl1.SetImage(img);
                thermalToolbarControl1.SetThermalImageControl(thermalImageControl1);
                playbackControl1.Initialize(img);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Close();
            }
        }
    }
}
