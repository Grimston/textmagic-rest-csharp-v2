/* 
 * TextMagic API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = TextMagicClient.Client.SwaggerDateConverter;

namespace TextMagicClient.Model
{
    /// <summary>
    /// GetAvailableDedicatedNumbersResponse
    /// </summary>
    [DataContract]
    public partial class GetAvailableDedicatedNumbersResponse :  IEquatable<GetAvailableDedicatedNumbersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableDedicatedNumbersResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAvailableDedicatedNumbersResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableDedicatedNumbersResponse" /> class.
        /// </summary>
        /// <param name="numbers">Array of phone numbers. (required).</param>
        /// <param name="price">Dedicated number monthly fee for this country. Returned in the current [account](http://docs.textmagictesting.com/#tag/User) currency. (required).</param>
        public GetAvailableDedicatedNumbersResponse(List<string> numbers = default(List<string>), float? price = default(float?))
        {
            // to ensure "numbers" is required (not null)
            if (numbers == null)
            {
                throw new InvalidDataException("numbers is a required property for GetAvailableDedicatedNumbersResponse and cannot be null");
            }
            else
            {
                this.Numbers = numbers;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for GetAvailableDedicatedNumbersResponse and cannot be null");
            }
            else
            {
                this.Price = price;
            }
        }
        
        /// <summary>
        /// Array of phone numbers.
        /// </summary>
        /// <value>Array of phone numbers.</value>
        [DataMember(Name="numbers", EmitDefaultValue=false)]
        public List<string> Numbers { get; set; }

        /// <summary>
        /// Dedicated number monthly fee for this country. Returned in the current [account](http://docs.textmagictesting.com/#tag/User) currency.
        /// </summary>
        /// <value>Dedicated number monthly fee for this country. Returned in the current [account](http://docs.textmagictesting.com/#tag/User) currency.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public float? Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAvailableDedicatedNumbersResponse {\n");
            sb.Append("  Numbers: ").Append(Numbers).Append("\n");
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
            return this.Equals(input as GetAvailableDedicatedNumbersResponse);
        }

        /// <summary>
        /// Returns true if GetAvailableDedicatedNumbersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAvailableDedicatedNumbersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAvailableDedicatedNumbersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Numbers == input.Numbers ||
                    this.Numbers != null &&
                    this.Numbers.SequenceEqual(input.Numbers)
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
                if (this.Numbers != null)
                    hashCode = hashCode * 59 + this.Numbers.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
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
