// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Microsoft.PowerBI.Api.V2;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI Rebind Report Request
    /// </summary>
    public partial class RebindReportRequest
    {
        /// <summary>
        /// Initializes a new instance of the RebindReportRequest class.
        /// </summary>
        public RebindReportRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RebindReportRequest class.
        /// </summary>
        /// <param name="datasetId">The new dataset of the rebinded
        /// report</param>
        public RebindReportRequest(string datasetId = default(string))
        {
            DatasetId = datasetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the new dataset of the rebinded report
        /// </summary>
        [JsonProperty(PropertyName = "datasetId")]
        public string DatasetId { get; set; }

    }
}
