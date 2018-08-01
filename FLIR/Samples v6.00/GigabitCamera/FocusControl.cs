using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Flir.Atlas.Live.Device;
using Flir.Atlas.Live.Remote;

namespace GigabitCamera
{
    public partial class FocusControl : UserControl
    {
        private const NumberStyles StyleDouble = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign;

        private ThermalCamera _camera;
        public FocusControl()
        {
            InitializeComponent();
        }

        public void SetCamera(ThermalCamera camera)
        {
            if (_camera != null)
            {
                _camera.ConnectionStatusChanged -= _camera_ConnectionStatusChanged;
                _camera = null;
            }
            if (camera != null)
            {
                _camera = camera;
                _camera.ConnectionStatusChanged += _camera_ConnectionStatusChanged;
                BeginInvoke(((Action)(() => UpdateButtons(_camera.ConnectionStatus))));
            }
        }

        private void UpdateButtons(ConnectionStatus connectionStatus)
        {
            if (connectionStatus == ConnectionStatus.Connected && _camera.RemoteControl.Focus.IsSupported())
            {
                groupBoxFocus.Enabled = true;
                try
                {
                    var distance = _camera.RemoteControl.Focus.GetDistance();
                    textBoxDistance.Enabled = true;
                    textBoxDistance.Text = distance.ToString("F1");
                }
                catch (Exception)
                {
                    textBoxDistance.Enabled = false;
                }
            }
            else
            {
                groupBoxFocus.Enabled = false;
            }
        }

        void _camera_ConnectionStatusChanged(object sender, Flir.Atlas.Live.ConnectionStatusChangedEventArgs e)
        {
            BeginInvoke(((Action) (() => UpdateButtons(e.Status))));
        }

        
        private void buttonFocusNear_MouseDown(object sender, MouseEventArgs e)
        {
            if (_camera != null)
            {
                _camera.RemoteControl.Focus.Mode(FocusMode.Near);
            }
        }

        private void buttonFocusNear_MouseUp(object sender, MouseEventArgs e)
        {
            if (_camera != null)
            {
                _camera.RemoteControl.Focus.Mode(FocusMode.Stop);
            }
        }

        private void buttonFocusAuto_Click(object sender, EventArgs e)
        {
            if (_camera != null)
            {
                _camera.RemoteControl.Focus.Mode(FocusMode.Auto);
            }
        }

        private void buttonFocusFar_MouseDown(object sender, MouseEventArgs e)
        {
            if (_camera != null)
            {
                _camera.RemoteControl.Focus.Mode(FocusMode.Far);
            }
        }

        private void buttonFocusFar_MouseUp(object sender, MouseEventArgs e)
        {
            if (_camera != null)
            {
                _camera.RemoteControl.Focus.Mode(FocusMode.Stop);
            }
        }

        private void buttonFocusDistance_Click(object sender, EventArgs e)
        {
            if (_camera == null) 
                return;

            double value;
            if (double.TryParse(textBoxDistance.Text, StyleDouble, CultureInfo.CurrentCulture, out value))
            {
                _camera.RemoteControl.Focus.SetDistance(value);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
