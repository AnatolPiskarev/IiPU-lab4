using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using DeviceStatus;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
       private List<Device> devList;
        public Form1()
        {
            InitializeComponent();
            DeviceAction devAction = new DeviceAction();
            HashSet<String> devList = new HashSet<string>(devAction.getDeviceList());

            foreach (String description in devList)
                deviceList.Items.Add(description);
        }

          

        

        private void deviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeviceAction devAction = new DeviceAction();
            deviceComboBox.Items.Clear();
            String devDescription = deviceList.SelectedItem.ToString();
            devList = devAction.getInformation(devDescription);
            foreach (Device dev in devList)
            {
                    deviceComboBox.Items.Add(dev.getName());
 
            }
        }

        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (Device dev in devList)
            {
                if (dev.getName().Equals(deviceComboBox.SelectedItem.ToString()))
                {
                    textBox1.AppendText("Name: " + dev.getName() + "\r\n");
                    textBox1.AppendText("DeviceId: " + dev.getDeviceId() + "\r\n");
                    textBox1.AppendText("Status: " + dev.getStatus() + "\r\n");
                    textBox1.AppendText("Manufactuer: " + dev.getManufacturer() + "\r\n");
                }
                break;
            }

        }
    }
}
