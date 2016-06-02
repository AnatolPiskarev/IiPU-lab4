using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using WindowsFormsApplication2;
using Microsoft.Win32.SafeHandles;

namespace DeviceStatus
{
    class DeviceAction

    {
        public List<String> getDeviceList()
        {
            String description;
            List<String> descList = new List<String>();
            ManagementObjectSearcher deviceList =
               new ManagementObjectSearcher("Select Description from Win32_PnPEntity");
            if (deviceList != null)
                // Enumerate the devicesdf
                foreach (ManagementObject device in deviceList.Get())
                {
                    try {
                        description = (device.GetPropertyValue("Description").ToString());
                    } catch (NullReferenceException) {
                        return descList;
                            }
                    descList.Add(description);
                }
            return descList;
        }

        public List<Device> getInformation(string description)
        {
            List<Device> devList = new List<Device>();
            ManagementObjectSearcher deviceList =
              new ManagementObjectSearcher("Select * from Win32_PnPEntity WHERE Description = '" + description + "'");
            if (deviceList != null)
                foreach (ManagementObject device in deviceList.Get())
                {
                    Device dev = new Device();
                    try
                    {
                        dev.setDescription(device.GetPropertyValue("Description").ToString());
                        dev.setStatus(device.GetPropertyValue("Status").ToString());
                        dev.setDeviceId(device.GetPropertyValue("DeviceID").ToString());
                        dev.setName(device.GetPropertyValue("Name").ToString());
                         dev.setManufacturer(device.GetPropertyValue("Manufacturer").ToString());
                    }
                    catch (System.NullReferenceException)
                    {
                        return devList;
                    }
                    devList.Add(dev);
                }
                return devList;
        }
        public void disable(string instanceId) {

                           }

        public void enable(Device dev) { }
    }

    
}
