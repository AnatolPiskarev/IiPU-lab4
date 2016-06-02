using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Device
    {
        private String name;
        private String status;
        private String description;
        private String deviceId;
        private String manufacturer;

        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getStatus()
        {
            return this.status;
        }
        public void setStatus(String status)
        {
            this.status = status;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public String getDescription()
        {
            return this.description;
        }
        public void setDeviceId(String deviceId)
        {
            this.deviceId = deviceId;
        }
        public String getDeviceId()
        {
            return this.deviceId;
        }
        public String getManufacturer()
        {
            return this.manufacturer;
        }
        public void setManufacturer(String manufacturer)
        {
            this.manufacturer = manufacturer;
        }
    }
}
