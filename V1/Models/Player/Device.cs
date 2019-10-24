using System;
using System.Collections.Generic;
using System.Text;

namespace Remotify.V1.Models.Player
{

    public class Device
    {
        public string id { get; set; }
        public bool is_active { get; set; }
        public bool is_private_session { get; set; }
        public bool is_restricted { get; set; }
        public string name { get; set; }
        public DeviceType type { get; set; }
        public int volume_percent { get; set; }
    }

}
