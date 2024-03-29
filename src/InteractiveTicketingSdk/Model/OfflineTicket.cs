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
    /// OfflineTicket
    /// </summary>
    [DataContract]
        public partial class OfflineTicket :  IEquatable<OfflineTicket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfflineTicket" /> class.
        /// </summary>
        /// <param name="offlineTicketId">The ticket ID.</param>
        /// <param name="testTicket">True if test mode.</param>
        /// <param name="barcode">The ticket barcode.</param>
        /// <param name="name">Name of ticket.</param>
        /// <param name="price">Purchase price for the ticket.</param>
        /// <param name="details">Details about the ticket.</param>
        /// <param name="slotDate">Applicable to timed ticketing.</param>
        /// <param name="slotTime">Applicable to timed ticketing.</param>
        /// <param name="seatCustom1">Applicable to reserved seating.</param>
        /// <param name="seatCustom2">Applicable to reserved seating.</param>
        /// <param name="seatSection">Applicable to reserved seating.</param>
        /// <param name="seatRow">Applicable to reserved seating.</param>
        /// <param name="seatNumber">Applicable to reserved seating.</param>
        /// <param name="canceled">Canceled / Voided ticket.</param>
        /// <param name="scans">Array of ticket scan activity.</param>
        /// <param name="scanPointConfig">scanPointConfig.</param>
        public OfflineTicket(int? offlineTicketId = default(int?), bool? testTicket = default(bool?), string barcode = default(string), string name = default(string), string price = default(string), string details = default(string), string slotDate = default(string), string slotTime = default(string), string seatCustom1 = default(string), string seatCustom2 = default(string), string seatSection = default(string), string seatRow = default(string), int? seatNumber = default(int?), bool? canceled = default(bool?), List<Scan> scans = default(List<Scan>), ScanPointConfig scanPointConfig = default(ScanPointConfig))
        {
            this.OfflineTicketId = offlineTicketId;
            this.TestTicket = testTicket;
            this.Barcode = barcode;
            this.Name = name;
            this.Price = price;
            this.Details = details;
            this.SlotDate = slotDate;
            this.SlotTime = slotTime;
            this.SeatCustom1 = seatCustom1;
            this.SeatCustom2 = seatCustom2;
            this.SeatSection = seatSection;
            this.SeatRow = seatRow;
            this.SeatNumber = seatNumber;
            this.Canceled = canceled;
            this.Scans = scans;
            this.ScanPointConfig = scanPointConfig;
        }
        
        /// <summary>
        /// The ticket ID
        /// </summary>
        /// <value>The ticket ID</value>
        [DataMember(Name="offlineTicketId", EmitDefaultValue=false)]
        public int? OfflineTicketId { get; set; }

        /// <summary>
        /// True if test mode
        /// </summary>
        /// <value>True if test mode</value>
        [DataMember(Name="testTicket", EmitDefaultValue=false)]
        public bool? TestTicket { get; set; }

        /// <summary>
        /// The ticket barcode
        /// </summary>
        /// <value>The ticket barcode</value>
        [DataMember(Name="barcode", EmitDefaultValue=false)]
        public string Barcode { get; set; }

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
        /// Details about the ticket
        /// </summary>
        /// <value>Details about the ticket</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Applicable to timed ticketing
        /// </summary>
        /// <value>Applicable to timed ticketing</value>
        [DataMember(Name="slotDate", EmitDefaultValue=false)]
        public string SlotDate { get; set; }

        /// <summary>
        /// Applicable to timed ticketing
        /// </summary>
        /// <value>Applicable to timed ticketing</value>
        [DataMember(Name="slotTime", EmitDefaultValue=false)]
        public string SlotTime { get; set; }

        /// <summary>
        /// Applicable to reserved seating
        /// </summary>
        /// <value>Applicable to reserved seating</value>
        [DataMember(Name="seatCustom1", EmitDefaultValue=false)]
        public string SeatCustom1 { get; set; }

        /// <summary>
        /// Applicable to reserved seating
        /// </summary>
        /// <value>Applicable to reserved seating</value>
        [DataMember(Name="seatCustom2", EmitDefaultValue=false)]
        public string SeatCustom2 { get; set; }

        /// <summary>
        /// Applicable to reserved seating
        /// </summary>
        /// <value>Applicable to reserved seating</value>
        [DataMember(Name="seatSection", EmitDefaultValue=false)]
        public string SeatSection { get; set; }

        /// <summary>
        /// Applicable to reserved seating
        /// </summary>
        /// <value>Applicable to reserved seating</value>
        [DataMember(Name="seatRow", EmitDefaultValue=false)]
        public string SeatRow { get; set; }

        /// <summary>
        /// Applicable to reserved seating
        /// </summary>
        /// <value>Applicable to reserved seating</value>
        [DataMember(Name="seatNumber", EmitDefaultValue=false)]
        public int? SeatNumber { get; set; }

        /// <summary>
        /// Canceled / Voided ticket
        /// </summary>
        /// <value>Canceled / Voided ticket</value>
        [DataMember(Name="canceled", EmitDefaultValue=false)]
        public bool? Canceled { get; set; }

        /// <summary>
        /// Array of ticket scan activity
        /// </summary>
        /// <value>Array of ticket scan activity</value>
        [DataMember(Name="_scans", EmitDefaultValue=false)]
        public List<Scan> Scans { get; set; }

        /// <summary>
        /// Gets or Sets ScanPointConfig
        /// </summary>
        [DataMember(Name="_scanPointConfig", EmitDefaultValue=false)]
        public ScanPointConfig ScanPointConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfflineTicket {\n");
            sb.Append("  OfflineTicketId: ").Append(OfflineTicketId).Append("\n");
            sb.Append("  TestTicket: ").Append(TestTicket).Append("\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  SlotDate: ").Append(SlotDate).Append("\n");
            sb.Append("  SlotTime: ").Append(SlotTime).Append("\n");
            sb.Append("  SeatCustom1: ").Append(SeatCustom1).Append("\n");
            sb.Append("  SeatCustom2: ").Append(SeatCustom2).Append("\n");
            sb.Append("  SeatSection: ").Append(SeatSection).Append("\n");
            sb.Append("  SeatRow: ").Append(SeatRow).Append("\n");
            sb.Append("  SeatNumber: ").Append(SeatNumber).Append("\n");
            sb.Append("  Canceled: ").Append(Canceled).Append("\n");
            sb.Append("  Scans: ").Append(Scans).Append("\n");
            sb.Append("  ScanPointConfig: ").Append(ScanPointConfig).Append("\n");
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
            return this.Equals(input as OfflineTicket);
        }

        /// <summary>
        /// Returns true if OfflineTicket instances are equal
        /// </summary>
        /// <param name="input">Instance of OfflineTicket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfflineTicket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OfflineTicketId == input.OfflineTicketId ||
                    (this.OfflineTicketId != null &&
                    this.OfflineTicketId.Equals(input.OfflineTicketId))
                ) && 
                (
                    this.TestTicket == input.TestTicket ||
                    (this.TestTicket != null &&
                    this.TestTicket.Equals(input.TestTicket))
                ) && 
                (
                    this.Barcode == input.Barcode ||
                    (this.Barcode != null &&
                    this.Barcode.Equals(input.Barcode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.SlotDate == input.SlotDate ||
                    (this.SlotDate != null &&
                    this.SlotDate.Equals(input.SlotDate))
                ) && 
                (
                    this.SlotTime == input.SlotTime ||
                    (this.SlotTime != null &&
                    this.SlotTime.Equals(input.SlotTime))
                ) && 
                (
                    this.SeatCustom1 == input.SeatCustom1 ||
                    (this.SeatCustom1 != null &&
                    this.SeatCustom1.Equals(input.SeatCustom1))
                ) && 
                (
                    this.SeatCustom2 == input.SeatCustom2 ||
                    (this.SeatCustom2 != null &&
                    this.SeatCustom2.Equals(input.SeatCustom2))
                ) && 
                (
                    this.SeatSection == input.SeatSection ||
                    (this.SeatSection != null &&
                    this.SeatSection.Equals(input.SeatSection))
                ) && 
                (
                    this.SeatRow == input.SeatRow ||
                    (this.SeatRow != null &&
                    this.SeatRow.Equals(input.SeatRow))
                ) && 
                (
                    this.SeatNumber == input.SeatNumber ||
                    (this.SeatNumber != null &&
                    this.SeatNumber.Equals(input.SeatNumber))
                ) && 
                (
                    this.Canceled == input.Canceled ||
                    (this.Canceled != null &&
                    this.Canceled.Equals(input.Canceled))
                ) && 
                (
                    this.Scans == input.Scans ||
                    this.Scans != null &&
                    input.Scans != null &&
                    this.Scans.SequenceEqual(input.Scans)
                ) && 
                (
                    this.ScanPointConfig == input.ScanPointConfig ||
                    (this.ScanPointConfig != null &&
                    this.ScanPointConfig.Equals(input.ScanPointConfig))
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
                if (this.OfflineTicketId != null)
                    hashCode = hashCode * 59 + this.OfflineTicketId.GetHashCode();
                if (this.TestTicket != null)
                    hashCode = hashCode * 59 + this.TestTicket.GetHashCode();
                if (this.Barcode != null)
                    hashCode = hashCode * 59 + this.Barcode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.SlotDate != null)
                    hashCode = hashCode * 59 + this.SlotDate.GetHashCode();
                if (this.SlotTime != null)
                    hashCode = hashCode * 59 + this.SlotTime.GetHashCode();
                if (this.SeatCustom1 != null)
                    hashCode = hashCode * 59 + this.SeatCustom1.GetHashCode();
                if (this.SeatCustom2 != null)
                    hashCode = hashCode * 59 + this.SeatCustom2.GetHashCode();
                if (this.SeatSection != null)
                    hashCode = hashCode * 59 + this.SeatSection.GetHashCode();
                if (this.SeatRow != null)
                    hashCode = hashCode * 59 + this.SeatRow.GetHashCode();
                if (this.SeatNumber != null)
                    hashCode = hashCode * 59 + this.SeatNumber.GetHashCode();
                if (this.Canceled != null)
                    hashCode = hashCode * 59 + this.Canceled.GetHashCode();
                if (this.Scans != null)
                    hashCode = hashCode * 59 + this.Scans.GetHashCode();
                if (this.ScanPointConfig != null)
                    hashCode = hashCode * 59 + this.ScanPointConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
