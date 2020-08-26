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
    /// DimensionRulesMaxParcelDimensions
    /// </summary>
    [DataContract]
    public partial class DimensionRulesMaxParcelDimensions :  IEquatable<DimensionRulesMaxParcelDimensions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionRulesMaxParcelDimensions" /> class.
        /// </summary>
        /// <param name="length">length.</param>
        /// <param name="width">width.</param>
        /// <param name="height">height.</param>
        /// <param name="unitOfMeasurement">unitOfMeasurement.</param>
        public DimensionRulesMaxParcelDimensions(int length = default(int), decimal width = default(decimal), int height = default(int), string unitOfMeasurement = default(string))
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.UnitOfMeasurement = unitOfMeasurement;
        }
        
        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int Length { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int Height { get; set; }

        /// <summary>
        /// Gets or Sets UnitOfMeasurement
        /// </summary>
        [DataMember(Name="unitOfMeasurement", EmitDefaultValue=false)]
        public string UnitOfMeasurement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimensionRulesMaxParcelDimensions {\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  UnitOfMeasurement: ").Append(UnitOfMeasurement).Append("\n");
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
            return this.Equals(input as DimensionRulesMaxParcelDimensions);
        }

        /// <summary>
        /// Returns true if DimensionRulesMaxParcelDimensions instances are equal
        /// </summary>
        /// <param name="input">Instance of DimensionRulesMaxParcelDimensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DimensionRulesMaxParcelDimensions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.UnitOfMeasurement == input.UnitOfMeasurement ||
                    (this.UnitOfMeasurement != null &&
                    this.UnitOfMeasurement.Equals(input.UnitOfMeasurement))
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
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.UnitOfMeasurement != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasurement.GetHashCode();
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
