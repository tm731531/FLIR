using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Flir.Atlas.Live.Device;
using Flir.Atlas.Live.Log;

namespace GigabitCamera
{
    public partial class LoggerWindow : Form
    {
        private CameraBase _camera;
        public LoggerWindow()
        {
            InitializeComponent();

            listBoxExecutedCommands.DrawMode = DrawMode.OwnerDrawVariable;
            listBoxExecutedCommands.MeasureItem += listBoxExecutedCommands_MeasureItem;
            listBoxExecutedCommands.DrawItem += listBoxExecutedCommands_DrawItem;
        }

        void listBoxExecutedCommands_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (listBoxExecutedCommands.Items.Count > 0)
                {
                    e.DrawBackground();
                    e.DrawFocusRectangle();
                    e.Graphics.DrawString(listBoxExecutedCommands.Items[e.Index].ToString(), e.Font,
                        new SolidBrush(e.ForeColor), e.Bounds);
                }
            }
            catch (Exception)
            {
                
                
            }
            
        }

        void listBoxExecutedCommands_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            try
            {
                if (listBoxExecutedCommands.Items.Count > 0)
                {

                    e.ItemHeight = (int)e.Graphics.MeasureString(listBoxExecutedCommands.Items[e.Index].ToString(),
                        listBoxExecutedCommands.Font,
                        listBoxExecutedCommands.Width).Height;
                }
            }
            catch (Exception)
            {
                
                
            }
        }

        public bool IsClosing { set; get; }

        public void SetCamera(ThermalCamera camera)
        {
            if (_camera != null)
            {
                LogWriter.Instance.Updated -= Instance_Updated;
                _camera.RemoteControl.CommandExecuted -= RemoteControl_CommandExecuted;
                _camera = null;
            }
            if (camera != null)
            {
                _camera = camera;
                LogWriter.Instance.Updated += Instance_Updated;
                _camera.RemoteControl.CommandExecuted += RemoteControl_CommandExecuted;
            }
        }

        void RemoteControl_CommandExecuted(object sender, Flir.Atlas.Live.Remote.CommandExecutedEventArgs e)
        {
            BeginInvoke((Action) (() => ExecutedCommandsUpdated(e.Command)));
        }

        private void ExecutedCommandsUpdated(Flir.Atlas.Live.Remote.Command command)
        {
            if (listBoxExecutedCommands.Items.Count > 1000)
            {
                listBoxExecutedCommands.Items.Clear();
            }
            listBoxExecutedCommands.Items.Insert(0, command.Xml.ToString());
        }

        void Instance_Updated(object sender, LogEventArgs e)
        {
            BeginInvoke((Action) (() => UpdateLog(e.Message)));
        }

        void UpdateLog(LogMessage entry)
        {
            if (listBoxLogger.Items.Count > 1000)
            {
                listBoxLogger.Items.Clear();
            }
            listBoxLogger.Items.Insert(0, string.Format("{0} {1}\t{2}", entry.LogDate, entry.LogTime, entry.Message));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (IsClosing)
            {
                if (_camera != null)
                {
                    LogWriter.Instance.Updated -= Instance_Updated;
                    _camera = null;
                }
                base.OnClosing(e);
            }
            else
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
