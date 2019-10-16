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
    /// ScanPoint
    /// </summary>
    [DataContract]
        public partial class ScanPoint :  IEquatable<ScanPoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanPoint" /> class.
        /// </summary>
        /// <param name="scanPointId">The Scan Point ID.</param>
        /// <param name="name">The Scan Point name.</param>
        public ScanPoint(int? scanPointId = default(int?), string name = default(string))
        {
            this.ScanPointId = scanPointId;
            this.Name = name;
        }
        
        /// <summary>
        /// The Scan Point ID
        /// </summary>
        /// <value>The Scan Point ID</value>
        [DataMember(Name="scanPointId", EmitDefaultValue=false)]
        public int? ScanPointId { get; set; }

        /// <summary>
        /// The Scan Point name
        /// </summary>
        /// <value>The Scan Point name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScanPoint {\n");
            sb.Append("  ScanPointId: ").Append(ScanPointId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ScanPoint);
        }

        /// <summary>
        /// Returns true if ScanPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScanPointId == input.ScanPointId ||
                    (this.ScanPointId != null &&
                    this.ScanPointId.Equals(input.ScanPointId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ScanPointId != null)
                    hashCode = hashCode * 59 + this.ScanPointId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
