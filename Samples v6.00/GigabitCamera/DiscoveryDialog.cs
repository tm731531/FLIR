using System;
using System.Threading;
using System.Windows.Forms;
using Flir.Atlas.Live.Discovery;
using Flir.Atlas.Live.Device;

namespace GigabitCamera
{
    public partial class DiscoveryDialog : Form
    {
        private readonly Discovery _discovery;

        public DiscoveryDialog()
        {
            InitializeComponent();

            _discovery = new Discovery();
            _discovery.DeviceFound += _discovery_DeviceFound;
            _discovery.DeviceLost += _discovery_DeviceLost;
            _discovery.DeviceError += _discovery_DeviceError;
            _discovery.Start(Interface.Gigabit);
        }

        void _discovery_DeviceError(object sender, DeviceErrorEventArgs e)
        {
            BeginInvoke((Action)(() => ShowError(e.ErrorMessage)));
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        void _discovery_DeviceLost(object sender, CameraDeviceInfoEventArgs e)
        {
            BeginInvoke((Action)(() => RemoveDevice(e.CameraDevice)));
        }

        void _discovery_DeviceFound(object sender, CameraDeviceInfoEventArgs e)
        {
            BeginInvoke((Action)(()=>AddDevice(e.CameraDevice)));
        }

        private void RemoveDevice(CameraDeviceInfo cameraDeviceInfo)
        {
            foreach (ListViewItem item in listViewDevices.Items)
            {
                var device = item.Tag as CameraDeviceInfo;
                if (device != null && device.DeviceIdentifier == cameraDeviceInfo.DeviceIdentifier)
                {
                    listViewDevices.Items.Remove(item);
                }
            }
        }

        private void AddDevice(CameraDeviceInfo cameraDeviceInfo)
        {
            var item = new ListViewItem(string.Format("{0}", cameraDeviceInfo.Name));
            foreach (var streamingFormat in cameraDeviceInfo.StreamingFormats)
            {
                if (streamingFormat == ImageFormat.FlirFileFormat)
                {
                    item.SubItems.Add(cameraDeviceInfo.IpSettings != null ? cameraDeviceInfo.IpSettings.IpAddress : "N/A");
                    item.SubItems.Add(cameraDeviceInfo.IpSettings != null ? cameraDeviceInfo.IpSettings.Mac : "N/A");
                    item.Tag = cameraDeviceInfo;
                    listViewDevices.Items.Add(item);
                }
            }
        }

        private void listViewDevices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _discovery.Stop();

            ListView.SelectedListViewItemCollection items = listViewDevices.SelectedItems;
            if (items.Count > 0)
            {
                ListViewItem lv = items[0];
                var device = lv.Tag as CameraDeviceInfo;
                SelectedCameraDevice = device;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        public CameraDeviceInfo SelectedCameraDevice { get; set; }

        private void DiscoveryDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            _discovery.DeviceFound -= _discovery_DeviceFound;
            _discovery.DeviceLost -= _discovery_DeviceLost;
            _discovery.DeviceError -= _discovery_DeviceError;
            ThreadPool.QueueUserWorkItem(DisposeDiscovery, _discovery);
        }

        static void DisposeDiscovery(Object context)
        {
            var discovery = (Discovery) context;
            discovery.Dispose();
        }
    }
}
