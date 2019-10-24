using Remotify.V1.Models.Common.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remotify.V1.Models.Player.Reponses
{
    class Devices : BaseResponse
    {
        public Device[] devices { get; set; }
    }
}
