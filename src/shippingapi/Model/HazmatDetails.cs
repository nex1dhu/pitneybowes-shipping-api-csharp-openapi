/* 
 * Shipping API
 *
 * Shipping API Sample.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@pb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = shippingapi.Client.OpenAPIDateConverter;

namespace shippingapi.Model
{
    /// <summary>
    /// HazmatDetails
    /// </summary>
    [DataContract]
    public partial class HazmatDetails :  IEquatable<HazmatDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HazmatDetails" /> class.
        /// </summary>
        /// <param name="batteryDetails">batteryDetails.</param>
        /// <param name="commodityType">commodityType.</param>
        /// <param name="containerCount">containerCount.</param>
        /// <param name="containerDetails">containerDetails.</param>
        /// <param name="emergencyContactNumber">emergencyContactNumber.</param>
        /// <param name="hazmatDocumentType">hazmatDocumentType.</param>
        /// <param name="identicalContainers">identicalContainers.</param>
        /// <param name="offeror">offeror.</param>
        /// <param name="packagingOption">packagingOption.</param>
        /// <param name="signatory">signatory.</param>
        public HazmatDetails(BatteryDetails batteryDetails = default(BatteryDetails), string commodityType = default(string), int containerCount = default(int), List<ContainerDetails> containerDetails = default(List<ContainerDetails>), string emergencyContactNumber = default(string), string hazmatDocumentType = default(string), bool identicalContainers = default(bool), string offeror = default(string), string packagingOption = default(string), Signatory signatory = default(Signatory))
        {
            this.BatteryDetails = batteryDetails;
            this.CommodityType = commodityType;
            this.ContainerCount = containerCount;
            this.ContainerDetails = containerDetails;
            this.EmergencyContactNumber = emergencyContactNumber;
            this.HazmatDocumentType = hazmatDocumentType;
            this.IdenticalContainers = identicalContainers;
            this.Offeror = offeror;
            this.PackagingOption = packagingOption;
            this.Signatory = signatory;
        }
        
        /// <summary>
        /// Gets or Sets BatteryDetails
        /// </summary>
        [DataMember(Name="batteryDetails", EmitDefaultValue=false)]
        public BatteryDetails BatteryDetails { get; set; }

        /// <summary>
        /// Gets or Sets CommodityType
        /// </summary>
        [DataMember(Name="commodityType", EmitDefaultValue=false)]
        public string CommodityType { get; set; }

        /// <summary>
        /// Gets or Sets ContainerCount
        /// </summary>
        [DataMember(Name="containerCount", EmitDefaultValue=false)]
        public int ContainerCount { get; set; }

        /// <summary>
        /// Gets or Sets ContainerDetails
        /// </summary>
        [DataMember(Name="containerDetails", EmitDefaultValue=false)]
        public List<ContainerDetails> ContainerDetails { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyContactNumber
        /// </summary>
        [DataMember(Name="emergencyContactNumber", EmitDefaultValue=false)]
        public string EmergencyContactNumber { get; set; }

        /// <summary>
        /// Gets or Sets HazmatDocumentType
        /// </summary>
        [DataMember(Name="hazmatDocumentType", EmitDefaultValue=false)]
        public string HazmatDocumentType { get; set; }

        /// <summary>
        /// Gets or Sets IdenticalContainers
        /// </summary>
        [DataMember(Name="identicalContainers", EmitDefaultValue=false)]
        public bool IdenticalContainers { get; set; }

        /// <summary>
        /// Gets or Sets Offeror
        /// </summary>
        [DataMember(Name="offeror", EmitDefaultValue=false)]
        public string Offeror { get; set; }

        /// <summary>
        /// Gets or Sets PackagingOption
        /// </summary>
        [DataMember(Name="packagingOption", EmitDefaultValue=false)]
        public string PackagingOption { get; set; }

        /// <summary>
        /// Gets or Sets Signatory
        /// </summary>
        [DataMember(Name="signatory", EmitDefaultValue=false)]
        public Signatory Signatory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HazmatDetails {\n");
            sb.Append("  BatteryDetails: ").Append(BatteryDetails).Append("\n");
            sb.Append("  CommodityType: ").Append(CommodityType).Append("\n");
            sb.Append("  ContainerCount: ").Append(ContainerCount).Append("\n");
            sb.Append("  ContainerDetails: ").Append(ContainerDetails).Append("\n");
            sb.Append("  EmergencyContactNumber: ").Append(EmergencyContactNumber).Append("\n");
            sb.Append("  HazmatDocumentType: ").Append(HazmatDocumentType).Append("\n");
            sb.Append("  IdenticalContainers: ").Append(IdenticalContainers).Append("\n");
            sb.Append("  Offeror: ").Append(Offeror).Append("\n");
            sb.Append("  PackagingOption: ").Append(PackagingOption).Append("\n");
            sb.Append("  Signatory: ").Append(Signatory).Append("\n");
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
            return this.Equals(input as HazmatDetails);
        }

        /// <summary>
        /// Returns true if HazmatDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of HazmatDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HazmatDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatteryDetails == input.BatteryDetails ||
                    (this.BatteryDetails != null &&
                    this.BatteryDetails.Equals(input.BatteryDetails))
                ) && 
                (
                    this.CommodityType == input.CommodityType ||
                    (this.CommodityType != null &&
                    this.CommodityType.Equals(input.CommodityType))
                ) && 
                (
                    this.ContainerCount == input.ContainerCount ||
                    (this.ContainerCount != null &&
                    this.ContainerCount.Equals(input.ContainerCount))
                ) && 
                (
                    this.ContainerDetails == input.ContainerDetails ||
                    this.ContainerDetails != null &&
                    input.ContainerDetails != null &&
                    this.ContainerDetails.SequenceEqual(input.ContainerDetails)
                ) && 
                (
                    this.EmergencyContactNumber == input.EmergencyContactNumber ||
                    (this.EmergencyContactNumber != null &&
                    this.EmergencyContactNumber.Equals(input.EmergencyContactNumber))
                ) && 
                (
                    this.HazmatDocumentType == input.HazmatDocumentType ||
                    (this.HazmatDocumentType != null &&
                    this.HazmatDocumentType.Equals(input.HazmatDocumentType))
                ) && 
                (
                    this.IdenticalContainers == input.IdenticalContainers ||
                    (this.IdenticalContainers != null &&
                    this.IdenticalContainers.Equals(input.IdenticalContainers))
                ) && 
                (
                    this.Offeror == input.Offeror ||
                    (this.Offeror != null &&
                    this.Offeror.Equals(input.Offeror))
                ) && 
                (
                    this.PackagingOption == input.PackagingOption ||
                    (this.PackagingOption != null &&
                    this.PackagingOption.Equals(input.PackagingOption))
                ) && 
                (
                    this.Signatory == input.Signatory ||
                    (this.Signatory != null &&
                    this.Signatory.Equals(input.Signatory))
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
                if (this.BatteryDetails != null)
                    hashCode = hashCode * 59 + this.BatteryDetails.GetHashCode();
                if (this.CommodityType != null)
                    hashCode = hashCode * 59 + this.CommodityType.GetHashCode();
                if (this.ContainerCount != null)
                    hashCode = hashCode * 59 + this.ContainerCount.GetHashCode();
                if (this.ContainerDetails != null)
                    hashCode = hashCode * 59 + this.ContainerDetails.GetHashCode();
                if (this.EmergencyContactNumber != null)
                    hashCode = hashCode * 59 + this.EmergencyContactNumber.GetHashCode();
                if (this.HazmatDocumentType != null)
                    hashCode = hashCode * 59 + this.HazmatDocumentType.GetHashCode();
                if (this.IdenticalContainers != null)
                    hashCode = hashCode * 59 + this.IdenticalContainers.GetHashCode();
                if (this.Offeror != null)
                    hashCode = hashCode * 59 + this.Offeror.GetHashCode();
                if (this.PackagingOption != null)
                    hashCode = hashCode * 59 + this.PackagingOption.GetHashCode();
                if (this.Signatory != null)
                    hashCode = hashCode * 59 + this.Signatory.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
