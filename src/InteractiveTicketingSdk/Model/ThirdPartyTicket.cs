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
    /// ThirdPartyTicket
    /// </summary>
    [DataContract]
        public partial class ThirdPartyTicket :  IEquatable<ThirdPartyTicket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyTicket" /> class.
        /// </summary>
        /// <param name="name">Name of ticket.</param>
        /// <param name="price">Purchase price for the ticket.</param>
        public ThirdPartyTicket(string name = default(string), string price = default(string))
        {
            this.Name = name;
            this.Price = price;
        }
        
        /// <summary>
        /// Name of ticket
        /// </summary>
        /// <value>Name of ticket</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Purchase price for the ticket
        /// </summary>
        /// <value>Purchase price for the ticket</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThirdPartyTicket {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
            return this.Equals(input as ThirdPartyTicket);
        }

        /// <summary>
        /// Returns true if ThirdPartyTicket instances are equal
        /// </summary>
        /// <param name="input">Instance of ThirdPartyTicket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThirdPartyTicket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                return hashCode;
            }
        }
    }
}
