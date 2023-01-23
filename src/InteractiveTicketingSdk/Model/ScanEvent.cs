/* 
 * Developer API
 *
 * Get your API Key from the [Dashboard](/dashboard/).<br/>Send all API requests with http header `X-API-Key: YOUR-API-KEY-HERE`.<br/>Base URL: `https://secure.interactiveticketing.com/developers/api/v4`<br/>Contact support@interactiveticketing.com for help.
 *
 * OpenAPI spec version: v4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = InteractiveTicketingSdk.Client.SwaggerDateConverter;

namespace InteractiveTicketingSdk.Model
{
    /// <summary>
    /// ScanEvent
    /// </summary>
    [DataContract]
        public partial class ScanEvent :  IEquatable<ScanEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanEvent" /> class.
        /// </summary>
        /// <param name="eventId">The event ID.</param>
        /// <param name="scanPointId">The Scan Point ID.</param>
        /// <param name="testMode">True indicates testMode, validate testMode tickets.</param>
        public ScanEvent(int? eventId = default(int?), int? scanPointId = default(int?), bool? testMode = default(bool?))
        {
            this.EventId = eventId;
            this.ScanPointId = scanPointId;
            this.TestMode = testMode;
        }
        
        /// <summary>
        /// The event ID
        /// </summary>
        /// <value>The event ID</value>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public int? EventId { get; set; }

        /// <summary>
        /// The Scan Point ID
        /// </summary>
        /// <value>The Scan Point ID</value>
        [DataMember(Name="scanPointId", EmitDefaultValue=false)]
        public int? ScanPointId { get; set; }

        /// <summary>
        /// True indicates testMode, validate testMode tickets
        /// </summary>
        /// <value>True indicates testMode, validate testMode tickets</value>
        [DataMember(Name="testMode", EmitDefaultValue=false)]
        public bool? TestMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScanEvent {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  ScanPointId: ").Append(ScanPointId).Append("\n");
            sb.Append("  TestMode: ").Append(TestMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScanEvent);
        }

        /// <summary>
        /// Returns true if ScanEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.ScanPointId == input.ScanPointId ||
                    (this.ScanPointId != null &&
                    this.ScanPointId.Equals(input.ScanPointId))
                ) && 
                (
                    this.TestMode == input.TestMode ||
                    (this.TestMode != null &&
                    this.TestMode.Equals(input.TestMode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.ScanPointId != null)
                    hashCode = hashCode * 59 + this.ScanPointId.GetHashCode();
                if (this.TestMode != null)
                    hashCode = hashCode * 59 + this.TestMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
