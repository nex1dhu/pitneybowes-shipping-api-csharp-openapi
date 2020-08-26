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
    /// SpecialServicesRule
    /// </summary>
    [DataContract]
    public partial class SpecialServicesRule :  IEquatable<SpecialServicesRule>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SpecialServiceId
        /// </summary>
        [DataMember(Name="specialServiceId", EmitDefaultValue=false)]
        public SpecialServiceCodes? SpecialServiceId { get; set; }
        /// <summary>
        /// Gets or Sets IncompatibleSpecialServices
        /// </summary>
        [DataMember(Name="incompatibleSpecialServices", EmitDefaultValue=false)]
        public SpecialServiceCodes? IncompatibleSpecialServices { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialServicesRule" /> class.
        /// </summary>
        /// <param name="specialServiceId">specialServiceId.</param>
        /// <param name="brandedName">brandedName.</param>
        /// <param name="categoryId">categoryId.</param>
        /// <param name="categoryName">categoryName.</param>
        /// <param name="trackable">trackable.</param>
        /// <param name="inputParameterRules">inputParameterRules.</param>
        /// <param name="prerequisiteRules">prerequisiteRules.</param>
        /// <param name="incompatibleSpecialServices">incompatibleSpecialServices.</param>
        public SpecialServicesRule(SpecialServiceCodes? specialServiceId = default(SpecialServiceCodes?), string brandedName = default(string), string categoryId = default(string), string categoryName = default(string), bool trackable = default(bool), List<ServicesParameterRule> inputParameterRules = default(List<ServicesParameterRule>), List<PrerequisiteRules> prerequisiteRules = default(List<PrerequisiteRules>), SpecialServiceCodes? incompatibleSpecialServices = default(SpecialServiceCodes?))
        {
            this.SpecialServiceId = specialServiceId;
            this.BrandedName = brandedName;
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.Trackable = trackable;
            this.InputParameterRules = inputParameterRules;
            this.PrerequisiteRules = prerequisiteRules;
            this.IncompatibleSpecialServices = incompatibleSpecialServices;
        }
        

        /// <summary>
        /// Gets or Sets BrandedName
        /// </summary>
        [DataMember(Name="brandedName", EmitDefaultValue=false)]
        public string BrandedName { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="categoryName", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or Sets Trackable
        /// </summary>
        [DataMember(Name="trackable", EmitDefaultValue=false)]
        public bool Trackable { get; set; }

        /// <summary>
        /// Gets or Sets InputParameterRules
        /// </summary>
        [DataMember(Name="inputParameterRules", EmitDefaultValue=false)]
        public List<ServicesParameterRule> InputParameterRules { get; set; }

        /// <summary>
        /// Gets or Sets PrerequisiteRules
        /// </summary>
        [DataMember(Name="prerequisiteRules", EmitDefaultValue=false)]
        public List<PrerequisiteRules> PrerequisiteRules { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecialServicesRule {\n");
            sb.Append("  SpecialServiceId: ").Append(SpecialServiceId).Append("\n");
            sb.Append("  BrandedName: ").Append(BrandedName).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  Trackable: ").Append(Trackable).Append("\n");
            sb.Append("  InputParameterRules: ").Append(InputParameterRules).Append("\n");
            sb.Append("  PrerequisiteRules: ").Append(PrerequisiteRules).Append("\n");
            sb.Append("  IncompatibleSpecialServices: ").Append(IncompatibleSpecialServices).Append("\n");
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
            return this.Equals(input as SpecialServicesRule);
        }

        /// <summary>
        /// Returns true if SpecialServicesRule instances are equal
        /// </summary>
        /// <param name="input">Instance of SpecialServicesRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpecialServicesRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpecialServiceId == input.SpecialServiceId ||
                    (this.SpecialServiceId != null &&
                    this.SpecialServiceId.Equals(input.SpecialServiceId))
                ) && 
                (
                    this.BrandedName == input.BrandedName ||
                    (this.BrandedName != null &&
                    this.BrandedName.Equals(input.BrandedName))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.Trackable == input.Trackable ||
                    (this.Trackable != null &&
                    this.Trackable.Equals(input.Trackable))
                ) && 
                (
                    this.InputParameterRules == input.InputParameterRules ||
                    this.InputParameterRules != null &&
                    input.InputParameterRules != null &&
                    this.InputParameterRules.SequenceEqual(input.InputParameterRules)
                ) && 
                (
                    this.PrerequisiteRules == input.PrerequisiteRules ||
                    this.PrerequisiteRules != null &&
                    input.PrerequisiteRules != null &&
                    this.PrerequisiteRules.SequenceEqual(input.PrerequisiteRules)
                ) && 
                (
                    this.IncompatibleSpecialServices == input.IncompatibleSpecialServices ||
                    (this.IncompatibleSpecialServices != null &&
                    this.IncompatibleSpecialServices.Equals(input.IncompatibleSpecialServices))
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
                if (this.SpecialServiceId != null)
                    hashCode = hashCode * 59 + this.SpecialServiceId.GetHashCode();
                if (this.BrandedName != null)
                    hashCode = hashCode * 59 + this.BrandedName.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.Trackable != null)
                    hashCode = hashCode * 59 + this.Trackable.GetHashCode();
                if (this.InputParameterRules != null)
                    hashCode = hashCode * 59 + this.InputParameterRules.GetHashCode();
                if (this.PrerequisiteRules != null)
                    hashCode = hashCode * 59 + this.PrerequisiteRules.GetHashCode();
                if (this.IncompatibleSpecialServices != null)
                    hashCode = hashCode * 59 + this.IncompatibleSpecialServices.GetHashCode();
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
