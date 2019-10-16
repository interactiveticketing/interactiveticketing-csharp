/* 
 * Developer API
 *
 * Get your API Key from the [Dashboard](/dashboard/).<br/>Send all API requests with http header `X-API-Key: YOUR-API-KEY-HERE`.<br/>Base URL: `https://secure.interactiveticketing.com/developers/api/v2`<br/>Contact support@interactiveticketing.com for help.
 *
 * OpenAPI spec version: v2
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
    /// ScanRequest
    /// </summary>
    [DataContract]
        public partial class ScanRequest :  IEquatable<ScanRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanRequest" /> class.
        /// </summary>
        /// <param name="barcode">The barcode string.</param>
        /// <param name="gate">The gate string.</param>
        /// <param name="scanEvents">Array of ScanEvent configurations.</param>
        public ScanRequest(string barcode = default(string), string gate = default(string), List<ScanEvent> scanEvents = default(List<ScanEvent>))
        {
            this.Barcode = barcode;
            this.Gate = gate;
            this.ScanEvents = scanEvents;
        }
        
        /// <summary>
        /// The barcode string
        /// </summary>
        /// <value>The barcode string</value>
        [DataMember(Name="barcode", EmitDefaultValue=false)]
        public string Barcode { get; set; }

        /// <summary>
        /// The gate string
        /// </summary>
        /// <value>The gate string</value>
        [DataMember(Name="gate", EmitDefaultValue=false)]
        public string Gate { get; set; }

        /// <summary>
        /// Array of ScanEvent configurations
        /// </summary>
        /// <value>Array of ScanEvent configurations</value>
        [DataMember(Name="scanEvents", EmitDefaultValue=false)]
        public List<ScanEvent> ScanEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScanRequest {\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
            sb.Append("  Gate: ").Append(Gate).Append("\n");
            sb.Append("  ScanEvents: ").Append(ScanEvents).Append("\n");
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
            return this.Equals(input as ScanRequest);
        }

        /// <summary>
        /// Returns true if ScanRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Barcode == input.Barcode ||
                    (this.Barcode != null &&
                    this.Barcode.Equals(input.Barcode))
                ) && 
                (
                    this.Gate == input.Gate ||
                    (this.Gate != null &&
                    this.Gate.Equals(input.Gate))
                ) && 
                (
                    this.ScanEvents == input.ScanEvents ||
                    this.ScanEvents != null &&
                    input.ScanEvents != null &&
                    this.ScanEvents.SequenceEqual(input.ScanEvents)
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
                if (this.Barcode != null)
                    hashCode = hashCode * 59 + this.Barcode.GetHashCode();
                if (this.Gate != null)
                    hashCode = hashCode * 59 + this.Gate.GetHashCode();
                if (this.ScanEvents != null)
                    hashCode = hashCode * 59 + this.ScanEvents.GetHashCode();
                return hashCode;
            }
        }
    }
}