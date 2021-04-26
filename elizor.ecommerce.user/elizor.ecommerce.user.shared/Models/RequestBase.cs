using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.shared.Models
{
    public class RequestBase
    {
        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the type of the device.
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// Gets or sets the device identifier.
        /// </summary>
        public string DeviceId { get; set; }
    }
}
