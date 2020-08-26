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
    /// RadioActiveParcelDimension
    /// </summary>
    [DataContract]
    public partial class RadioActiveParcelDimension :  IEquatable<RadioActiveParcelDimension>, IValidatableObject
    {
        /// <summary>
        /// unit of measurement
        /// </summary>
        /// <value>unit of measurement</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UOMEnum
        {
            /// <summary>
            /// Enum CM for value: CM
            /// </summary>
            [EnumMember(Value = "CM")]
            CM = 1,

            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 2

        }

        /// <summary>
        /// unit of measurement
        /// </summary>
        /// <value>unit of measurement</value>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public UOMEnum? UOM { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioActiveParcelDimension" /> class.
        /// </summary>
        /// <param name="uOM">unit of measurement.</param>
        /// <param name="height">height.</param>
        /// <param name="length">length.</param>
        /// <param name="width">width.</param>
        public RadioActiveParcelDimension(UOMEnum? uOM = default(UOMEnum?), decimal height = default(decimal), decimal length = default(decimal), decimal width = default(decimal))
        {
            this.UOM = uOM;
            this.Height = height;
            this.Length = length;
            this.Width = width;
        }
        

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public decimal Length { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public decimal Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadioActiveParcelDimension {\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as RadioActiveParcelDimension);
        }

        /// <summary>
        /// Returns true if RadioActiveParcelDimension instances are equal
        /// </summary>
        /// <param name="input">Instance of RadioActiveParcelDimension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadioActiveParcelDimension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
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
