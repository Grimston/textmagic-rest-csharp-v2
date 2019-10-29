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
    /// DeleteContactNotesBulkInputObject
    /// </summary>
    [DataContract]
    public partial class DeleteContactNotesBulkInputObject :  IEquatable<DeleteContactNotesBulkInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteContactNotesBulkInputObject" /> class.
        /// </summary>
        /// <param name="ids">Entity ID(s), separated by comma..</param>
        /// <param name="all">Entity ID(s), separated by comma..</param>
        public DeleteContactNotesBulkInputObject(string ids = default(string), bool? all = default(bool?))
        {
            this.Ids = ids;
            this.All = all;
        }
        
        /// <summary>
        /// Entity ID(s), separated by comma.
        /// </summary>
        /// <value>Entity ID(s), separated by comma.</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public string Ids { get; set; }

        /// <summary>
        /// Entity ID(s), separated by comma.
        /// </summary>
        /// <value>Entity ID(s), separated by comma.</value>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public bool? All { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteContactNotesBulkInputObject {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
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
            return this.Equals(input as DeleteContactNotesBulkInputObject);
        }

        /// <summary>
        /// Returns true if DeleteContactNotesBulkInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteContactNotesBulkInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteContactNotesBulkInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ids == input.Ids ||
                    (this.Ids != null &&
                    this.Ids.Equals(input.Ids))
                ) && 
                (
                    this.All == input.All ||
                    (this.All != null &&
                    this.All.Equals(input.All))
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
                if (this.Ids != null)
                    hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
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
