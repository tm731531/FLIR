using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Flir.Atlas.Live.Device;

namespace GigabitCamera
{
    public partial class ExternalIoForm : Form
    {
        private readonly ExternalIo _externalIo;
        private bool _initializing;

        public ExternalIoForm(ExternalIo externalIo)
        {
            _externalIo = externalIo;
            InitializeComponent();
        }

        private void ExternalIoForm_Load(object sender, EventArgs e)
        {
            _initializing = true;
            for (var i = 0; i < _externalIo.Settings.Count; i++)
            {
                comboBoxSelectedPort.Items.Add(i);
            }
            comboBoxSelectedPort.SelectedIndex = 0;
            _initializing = false;
            SelectPort(0);
        }

        private void comboBoxSelectedPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SelectPort(int port)
        {
            if (_initializing)
            {
                return;
            }
            var extIoSettings = _externalIo.Settings[port];
            labelType.Text = extIoSettings.Type.ToString();
            labelDirection.Text = extIoSettings.Direction.ToString();

            comboBoxConfig.Items.Clear();
            var list = Enum.GetValues(typeof (IoConfig));
            foreach (var item in list)
            {
                comboBoxConfig.Items.Add(item);
            }
            comboBoxConfig.SelectedIndex = (int) extIoSettings.Config;

            comboBoxPolarity.Items.Clear();
            list = Enum.GetValues(typeof (IoPolarity));
            foreach (var item in list)
            {
                comboBoxPolarity.Items.Add(item);
            }
            comboBoxPolarity.SelectedIndex = (int) extIoSettings.Polarity;

            comboBoxSensitivity.Items.Clear();
            list = Enum.GetValues(typeof (IoSensitivity));
            foreach (var item in list)
            {
                comboBoxSensitivity.Items.Add(item);
            }
            comboBoxSensitivity.SelectedIndex = (int) extIoSettings.Sensitivity;

            comboBoxState.Items.Clear();
            list = Enum.GetValues(typeof (IoState));
            foreach (var item in list)
            {
                comboBoxState.Items.Add(item);
            }
            comboBoxState.SelectedIndex = (int) extIoSettings.State;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            try
            {
                var port = comboBoxSelectedPort.SelectedIndex;
                _externalIo.Settings[port].Config = (IoConfig)Enum.Parse(typeof(IoConfig), comboBoxConfig.SelectedItem.ToString());
                _externalIo.Settings[port].Polarity = (IoPolarity)Enum.Parse(typeof(IoPolarity), comboBoxPolarity.SelectedItem.ToString());
                _externalIo.Settings[port].Sensitivity = (IoSensitivity)Enum.Parse(typeof(IoSensitivity), comboBoxSensitivity.SelectedItem.ToString());
                _externalIo.Settings[port].State = (IoState)Enum.Parse(typeof(IoState), comboBoxState.SelectedItem.ToString());
                _externalIo.Settings[port].Apply();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            


        }

        private void comboBoxSelectedPort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectPort(comboBoxSelectedPort.SelectedIndex);
        }
    }
}
