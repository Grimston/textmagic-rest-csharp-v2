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
    /// DeleteContacsFromListObject
    /// </summary>
    [DataContract]
    public partial class DeleteContacsFromListObject :  IEquatable<DeleteContacsFromListObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteContacsFromListObject" /> class.
        /// </summary>
        /// <param name="contacts">Comma-separated array of [Contacts](http://docs.textmagictesting.com/#tag/Contacts) IDs. .</param>
        public DeleteContacsFromListObject(string contacts = default(string))
        {
            this.Contacts = contacts;
        }
        
        /// <summary>
        /// Comma-separated array of [Contacts](http://docs.textmagictesting.com/#tag/Contacts) IDs. 
        /// </summary>
        /// <value>Comma-separated array of [Contacts](http://docs.textmagictesting.com/#tag/Contacts) IDs. </value>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public string Contacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteContacsFromListObject {\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
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
            return this.Equals(input as DeleteContacsFromListObject);
        }

        /// <summary>
        /// Returns true if DeleteContacsFromListObject instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteContacsFromListObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteContacsFromListObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contacts == input.Contacts ||
                    (this.Contacts != null &&
                    this.Contacts.Equals(input.Contacts))
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
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
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
