﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using Flir.Atlas.Live.Device;
using Flir.Atlas.Live.Discovery;
using Flir.Atlas.Image;
using System.IO;

namespace ThermalImageStreamerDemo
{
    public partial class MainForm : Form
    {
        private Camera _camera;
        readonly Timer _timerRefreshUi = new Timer();
        public MainForm()
        {
            InitializeComponent();
            _timerRefreshUi.Interval = 20;
            _timerRefreshUi.Tick += _timerRefreshUi_Tick;
        }

        void _timerRefreshUi_Tick(object sender, EventArgs e)
        {
            if (!IsDirty) return;
            IsDirty = false;
            if (_camera == null) return;

            _camera.GetImage().EnterLock();
            try
            {
                pictureBox1.Image = _camera.GetImage().Image;
            }
            catch (Exception exception)
            {
                Trace.TraceError(exception.Message);
            }
            finally
            {
                _camera.GetImage().ExitLock();
            }
        }

        private void discoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var discoveryDlg = new DiscoveryForm();
            if (discoveryDlg.ShowDialog() == DialogResult.OK)
            {
                ConnectCamera(discoveryDlg.SelectedCameraDevice);
            }
        }

        private void ConnectCamera(CameraDeviceInfo cameraDeviceInfo)
        {
            DisposeCamera();
            switch (cameraDeviceInfo.SelectedStreamingFormat)
            {
                case ImageFormat.FlirFileFormat:
                    _camera = new ThermalCamera();
                    break;
                case ImageFormat.Argb:
                    _camera = new VideoOverlayCamera();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            _camera.ConnectionStatusChanged += _camera_ConnectionStatusChanged;
            _camera.GetImage().Changed += Image_Changed;
            _camera.Connect(cameraDeviceInfo);
            if (_camera.Recorder == null && _recorder != null)
            {
                _recorder.Dispose();
                _recorder = null;
            }
            if (_recorder != null)
            {
                if (!_recorder.IsDisposed)
                    _recorder.Initialize(_camera);
            }
            recorderToolStripMenuItem.Enabled = _camera.Recorder != null;
            _timerRefreshUi.Start();
        }

        private void DisposeCamera()
        {
            _timerRefreshUi.Stop();
            if (_camera == null) return;
            if (_recorder != null)
            {
                _recorder.UnInitialize();
                _recorder.Dispose();
            }
            _camera.ConnectionStatusChanged -= _camera_ConnectionStatusChanged;
            _camera.GetImage().Changed -= Image_Changed;
            _camera.Dispose();
        }

        private bool IsDirty { get; set; }
        void Image_Changed(object sender, Flir.Atlas.Image.ImageChangedEventArgs e)
        {
            IsDirty = true;
        }

        void _camera_ConnectionStatusChanged(object sender, Flir.Atlas.Live.ConnectionStatusChangedEventArgs e)
        {
            BeginInvoke((Action) (()=> toolStripConnectionStatus.Text = e.Status.ToString()));
            BeginInvoke((Action)(() => cameraToolStripMenuItem.Enabled = e.Status == ConnectionStatus.Connected)); 
        }

        private void DisconnectCamera()
        {
            if (_camera == null) return;
            
            _camera.Disconnect();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisconnectCamera();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_recorder != null && _recorder.IsDisposed == false)
            {
                _recorder.Dispose();    
            }
            
            DisposeCamera();
        }

        private RecorderForm _recorder;
        private void recorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_recorder == null || _recorder.IsDisposed)
            {
                _recorder = new RecorderForm();
                _recorder.Initialize(_camera);
                _recorder.SelectedFileMouseDoubleClick += _recorder_SelectedFileMouseDoubleClick;
            }
            _recorder.Show();
            _recorder.Focus();
        }

        void _recorder_SelectedFileMouseDoubleClick(object sender, SelectedFileEventArgs e)
        {
            var playback = new PlaybackForm(e.FilePath);
            playback.Show();
        }

        private const string FileFilter = "IR Image Files(*.jpg;*.img;*.seq;*.fcf)|*.jpg;*.img;*.seq;*.fcf|All files (*.*)|*.*";

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\FLIR";
                dialog.Filter = FileFilter;
                if (dialog.ShowDialog() != DialogResult.OK) return;
                var playback = new PlaybackForm(dialog.FileName);
                playback.Show();
            }
        }
        string filename = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fde = new SaveFileDialog();
            fde.Filter = "CSV file(*.csv)|*.csv";
            fde.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            fde.RestoreDirectory = true;
            if (fde.ShowDialog() == DialogResult.OK)
            {
                filename = "TEMP.jpg";

                _camera.GetImage().EnterLock();
                try
                {
                    pictureBox1.Image = _camera.GetImage().Image;
                    ThermalImage th = _camera.GetImage() as ThermalImage;
                   // var q = d.ImageProcessing.GetPixels();
                    double[,] pixel_array2 = th.ImageProcessing.GetPixelsArray();
                    System.IO.StreamWriter file = new System.IO.StreamWriter(fde.FileName);
                    for (int y = 0; y < th.Height; y++)
                    {
                        string line = string.Empty;
                        for (int x = 0; x < th.Width; x++)
                        {
                            int pixel_int = (int)pixel_array2[y, x]; //casting the signal value to int
                            double pixel_temp = th.GetValueFromSignal(pixel_int); //converting signal to temperature
                            line += pixel_temp.ToString("0.00") + ";"; //"building" each line
                        }
                        file.WriteLine(line); //writing a line to the excel sheet
                    }
                    file.Flush();
                    file.Close();
                   // th.Dispose();

                }
                catch (Exception exception)
                {
                    Trace.TraceError(exception.Message);
                }
                finally
                {
                    _camera.GetImage().ExitLock();
                }
               // pictureBox1.Image.Save("TEMP.jpg");
              //  filename = "TEMP.jpg";

              
                //ThermalImageFile th = new ThermalImageFile(Path.Combine(Directory.GetCurrentDirectory(), filename));

                //double[,] pixel_array = th.ImageProcessing.GetPixelsArray(); //array containing the raw signal data
              
            }
        }
    }
}
