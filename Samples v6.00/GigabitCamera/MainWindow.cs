using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Flir.Atlas.Image;
using Flir.Atlas.Image.Palettes;
using Flir.Atlas.Live.Device;
using Flir.Atlas.Live.Remote;

namespace GigabitCamera
{
    public partial class MainWindow : Form
    {
        private readonly ThermalGigabitCamera _camera;
        private readonly ThermalImageFile _defaultImage = new ThermalImageFile();
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                _camera = new ThermalGigabitCamera();
                _camera.ConnectionStatusChanged += _camera_ConnectionStatusChanged;
                _camera.DeviceError += _camera_DeviceError;
            }
            catch (Exception)
            {
                MessageBox.Show("Missing Atlas dependencies, terminating.");
                Close();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _loggerWindow = new LoggerWindow();
            _loggerWindow.Show();
            _loggerWindow.Hide();
            _loggerWindow.SetCamera(_camera);

            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;


            pictureBox1.Image = _defaultImage.Image;

            UpdateStatus(_camera.ConnectionStatus);

            foreach (var palette in PaletteManager.Palettes)
            {
                comboBox1.Items.Add(palette.Name);
            }

            Text = "Thermal gigabit Camera Sample, running Atlas version: " + ImageBase.Version;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            labelFps.Text = string.Format("{0:G3}", _camera.Fps);
            labelFrameCounter.Text = string.Format("{0}", _camera.FrameCount);
            labelLostImages.Text = string.Format("{0}", _camera.LostImages);
            if (!IsDirty) 
                return;
            try
            {
                _camera.GetImage().EnterLock();
                pictureBox1.Image = _camera.GetImage().Image;
            }
            catch(Exception exception)
            {
                Debug.Print(exception.Message);
            }
            finally
            {
                _camera.GetImage().ExitLock();
            }
        }

        void _camera_DeviceError(object sender, DeviceErrorEventArgs e)
        {
            BeginInvoke((Action) (() => ShowErrorMessage(e.ErrorMessage)));
        }

        void ShowErrorMessage(string message)
        {
            // MessageBox.Show(message);
        }

        void _camera_ConnectionStatusChanged(object sender, Flir.Atlas.Live.ConnectionStatusChangedEventArgs e)
        {
            BeginInvoke((Action)(()=> UpdateStatus(e.Status)));

            if (e.Status != ConnectionStatus.Connected) return;
            try
            {
                var img = _camera.GetImage() as ThermalImage;
                img.Scale.IsAutoAdjustEnabled = true;
                img.Palette = PaletteManager.Iron;


                BeginInvoke((Action)(SetupPalette));
                BeginInvoke((Action)(SetupWorkingEnvironment));
                BeginInvoke((Action)(SetupSensorGainMode));
                var frameRates = _camera.EnumerateFrameRates();
                var index = _camera.FrameRateIndex;
                BeginInvoke((Action)(() => SetupFrameRate(frameRates, index)));
                BeginInvoke((Action)(SetupTrigger));
            }
            catch (Exception exception)
            {
                BeginInvoke((Action)(() => MessageBox.Show(exception.Message)));
            }
        }

        private void SetupTrigger()
        {
            if (_camera.Trigger != null)
            {
                buttonTriggerStatus.Enabled = true;
                _camera.Trigger.TriggerChangedDigitalPort1 += Trigger_TriggerChangedDigitalPort1;
                UpdateTriggerState(_camera.Trigger.TrigStateDigitalPort1);
            }
            else
            {
                buttonTriggerStatus.Enabled = false;
            }
            buttonExtIo.Enabled = _camera.ExternalIo != null;
        }

        void Trigger_TriggerChangedDigitalPort1(object sender, TriggerChangedEventArgs e)
        {
            BeginInvoke((Action)(()=>UpdateTriggerState(e.State)));
        }

        void UpdateTriggerState(bool state)
        {
            buttonTriggerStatus.BackColor = state ? Color.Red : Color.DarkGray;
        }
        
        private void SetupPalette()
        {
            var thermalImage = _camera.GetImage() as ThermalImage;
            if (thermalImage == null) return;
            for (var i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.Items[i].ToString() != thermalImage.Palette.Name) continue;
                comboBox1.SelectedIndex = i;
                break;
            }
        }

        private void SetupFrameRate(IEnumerable<string> values, int index)
        {
            comboBoxFrameRate.Enabled = true;
            comboBoxFrameRate.Items.Clear();
            foreach (var frameRate in values)
            {
                comboBoxFrameRate.Items.Add(frameRate);
            }
            comboBoxFrameRate.SelectedIndex = index;
        }

        private void SetupSensorGainMode()
        {
            comboBoxSensorGainMode.Items.Clear();
            try
            {
                var current = _camera.GetSensorGainMode();
                var modes = _camera.EnumSensorGainModes();
                if (modes.Any())
                {
                    var selectedIndex = 0;
                    for (var index = 0; index < modes.Count; index++)
                    {
                        var mode = modes[index];
                        if (mode == current)
                        {
                            selectedIndex = index;
                        }
                        comboBoxSensorGainMode.Items.Add(mode);
                    }
                    comboBoxSensorGainMode.Enabled = true;
                    comboBoxSensorGainMode.SelectedIndex = selectedIndex;
                }
                else
                {
                    comboBoxSensorGainMode.Enabled = false;
                }
            }
            catch (Exception)
            {
                comboBoxSensorGainMode.Enabled = false;
            }
        }

        private void SetupWorkingEnvironment()
        {
            try
            {
                comboBoxWorkingEnvironments.Items.Clear();
                if (_camera.HighSpeedInterface != null)
                {
                    var wenvs = _camera.HighSpeedInterface.GetWorkingEnvironments();
                    foreach (var workingEnvironment in wenvs)
                    {
                        comboBoxWorkingEnvironments.Items.Add(workingEnvironment.Description);
                    }
                    var index = _camera.HighSpeedInterface.GetCurrentWorkingEnvironmentIndex();
                    comboBoxWorkingEnvironments.SelectedIndex = index;
                    comboBoxWorkingEnvironments.Enabled = true;
                }
                else
                {
                    comboBoxWorkingEnvironments.Enabled = false;
                }
            }
            catch (CommandFailedException exception)
            {
                comboBoxWorkingEnvironments.Enabled = false;
                MessageBox.Show(exception.Message);
            }
        }

        private void UpdateStatus(ConnectionStatus status)
        {
            labelConnectionStatus.Text = status.ToString();
            buttonStopPlay.Enabled = status == ConnectionStatus.Connected;
            groupBox1.Enabled = status == ConnectionStatus.Connected;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var dlg = new DiscoveryDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _camera.Connect(dlg.SelectedCameraDevice);
                _camera.GetImage().Changed += MainWindow_Changed;
                
                timer1.Start();
                buttonDisconnect.Enabled = true;
                focusControl1.SetCamera(_camera);

            }
        }

        void MainWindow_Changed(object sender, ImageChangedEventArgs e)
        {
            IsDirty = true;
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            _camera.Disconnect();
            buttonDisconnect.Enabled = false;
        }

        public bool IsDirty { get; set; }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _camera.Disconnect();
            if (_loggerWindow != null)
            {
                _loggerWindow.IsClosing = true;
                _loggerWindow.Close();
            }
            if (_recording != null)
            {
                _recording.Close();
            }
            _camera.ConnectionStatusChanged -= _camera_ConnectionStatusChanged;
            focusControl1.SetCamera(null);
        }

        private void buttonStopPlay_Click(object sender, EventArgs e)
        {
            if (_camera.IsGrabbing)
            {
                _camera.StopGrabbing();
                buttonStopPlay.Text = "Play";
            }
            else
            {
                _camera.StartGrabbing();
                buttonStopPlay.Text = "Pause";
            }
        }

        private LoggerWindow _loggerWindow;
        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (_loggerWindow == null)
            {
                _loggerWindow = new LoggerWindow();
                _loggerWindow.SetCamera(_camera);
            }
            _loggerWindow.Show();
        }

        private void buttonCommunicationControl_Click(object sender, EventArgs e)
        {
            var genICamParameters = _camera.DeviceControl.GetHostCommunicationParameters();
            var dlg = new GenICamParameters(_camera);
            BeginInvoke((Action) (() => dlg.BuildTree(genICamParameters)));
            dlg.Show();
        }

        private void buttonDeviceSettings_Click(object sender, System.EventArgs e)
        {
            var genICamParameters = _camera.DeviceControl.GetDeviceParameters();
            var dlg = new GenICamParameters(_camera);
            BeginInvoke((Action)(() => dlg.BuildTree(genICamParameters)));
            dlg.Show();
        }

        private void buttonImageStreamControl_Click(object sender, EventArgs e)
        {
            var genICamParameters = _camera.DeviceControl.GetImageStreamParameters();
            var dlg = new GenICamParameters(_camera);
            BeginInvoke((Action)(() => dlg.BuildTree(genICamParameters)));
            dlg.Show();
        }

        private void buttonNUC_Click(object sender, EventArgs e)
        {
            _camera.DeviceControl.SetDeviceParameter("NUCAction", GenICamType.Command);

        }

        private void comboBoxWorkingEnvironments_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxWorkingEnvironments.SelectedIndex >= 0)
            {
                ThreadPool.QueueUserWorkItem(SelectWorkingEnvironment, comboBoxWorkingEnvironments.SelectedIndex);
            }
        }

        private void SelectWorkingEnvironment(Object context)
        {
            _camera.HighSpeedInterface.SetWorkingEnvironmentIndex((int)context);
            // Changing the working environment might also affect the frame rate.
            var frameRates = _camera.EnumerateFrameRates();
            var index = _camera.FrameRateIndex;
            BeginInvoke((Action)(() => SetupFrameRate(frameRates, index)));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_camera == null || string.IsNullOrEmpty(comboBox1.SelectedItem.ToString())) return;
            var thImg = _camera.GetImage() as ThermalImage;
            if (thImg == null) return;
            thImg.Palette = PaletteManager.FromString(comboBox1.SelectedItem.ToString());
            IsDirty = true;
        }

        private RecordingForm _recording;
        private void button1_Click(object sender, EventArgs e)
        {
            if (_recording == null || _recording.IsDisposed)
            {
                _recording = new RecordingForm();
                _recording.Show();
                _recording.SetThermalCamera(_camera);
            }
            else
            {
                _recording.Show();
                _recording.Focus();
            }
        }

        private void comboBoxSensorGainMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var mode = comboBoxSensorGainMode.SelectedItem;
            _camera.SetSensorGainMode(mode.ToString());
            
        }

        private void comboBoxFrameRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxFrameRate.Enabled = false;
            ThreadPool.QueueUserWorkItem(ChangeFrameRate, comboBoxFrameRate.SelectedIndex);
        }

        private void ChangeFrameRate(Object context)
        {
            if (!_camera.IsConnected)
                return;
            _camera.FrameRateIndex = (int)context;
            BeginInvoke((Action)(()=>comboBoxFrameRate.Enabled = true));
            // Changeing the frame rate might affect the current working environment.
            if (_camera.HighSpeedInterface != null)
            {
                BeginInvoke((Action)(SetupWorkingEnvironment));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\FLIR\"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\FLIR\");
            }

            try
            {
                _camera.GetImage().EnterLock();
                var image = new Bitmap(pictureBox1.Image);
                var fileDlg = new SaveFileDialog
                {
                    AddExtension = true,
                    DefaultExt = "jpg",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\FLIR\"
                };
                if (fileDlg.ShowDialog() == DialogResult.OK)
                {
                    _camera.GetImage().SaveSnapshot(fileDlg.FileName, image); 
                }
                
                image.Dispose();
            }
            catch (Exception exception)
            {
                ShowErrorMessage(exception.Message);
            }
            finally
            {
                _camera.GetImage().ExitLock();
            }
        }

        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "IR Image Files(*.jpg;*.seq;*.csq)|*.jpg;*.seq;*.csq|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var playback = new PlaybackDialog();
                    playback.Show();
                    playback.Open(dialog.FileName);
                }
            }
        }

        private void buttonExtIo_Click(object sender, EventArgs e)
        {
            var extIoDlg = new ExternalIoForm(_camera.ExternalIo);
            extIoDlg.Show();
        }
    }
}
