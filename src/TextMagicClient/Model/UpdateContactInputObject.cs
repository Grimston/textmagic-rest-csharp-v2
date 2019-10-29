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
    /// UpdateContactInputObject
    /// </summary>
    [DataContract]
    public partial class UpdateContactInputObject :  IEquatable<UpdateContactInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactInputObject" /> class.
        /// </summary>
        /// <param name="firstName">Contact first name..</param>
        /// <param name="lastName">Contact last name..</param>
        /// <param name="phone">Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164)..</param>
        /// <param name="email">Contact email address..</param>
        /// <param name="companyName">Contact company name..</param>
        /// <param name="lists">Comma-separated [list](http://docs.textmagictesting.com/#section/Lists) ID. Each contact must be assigned to at least one list..</param>
        /// <param name="favorited">Is the contact marked as favorite?.</param>
        /// <param name="blocked">Is the contact blocked for outgoing and incoming messaging?.</param>
        /// <param name="type">Force type of phone. Possible values: 0 is landline; 1 is mobile; default is -1 (auto-detection)..</param>
        /// <param name="customFieldValues">customFieldValues.</param>
        /// <param name="local">Treat phone numbers passed in the request body as **local**..</param>
        /// <param name="country">The 2-letter ISO country code for local phone numbers, used when **local** is set to true..</param>
        public UpdateContactInputObject(string firstName = default(string), string lastName = default(string), string phone = default(string), string email = default(string), string companyName = default(string), string lists = default(string), bool? favorited = default(bool?), bool? blocked = default(bool?), int? type = default(int?), List<CustomFieldListItem> customFieldValues = default(List<CustomFieldListItem>), int? local = default(int?), string country = default(string))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.CompanyName = companyName;
            this.Lists = lists;
            this.Favorited = favorited;
            this.Blocked = blocked;
            this.Type = type;
            this.CustomFieldValues = customFieldValues;
            this.Local = local;
            this.Country = country;
        }
        
        /// <summary>
        /// Contact first name.
        /// </summary>
        /// <value>Contact first name.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Contact last name.
        /// </summary>
        /// <value>Contact last name.</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164).
        /// </summary>
        /// <value>Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164).</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Contact email address.
        /// </summary>
        /// <value>Contact email address.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Contact company name.
        /// </summary>
        /// <value>Contact company name.</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Comma-separated [list](http://docs.textmagictesting.com/#section/Lists) ID. Each contact must be assigned to at least one list.
        /// </summary>
        /// <value>Comma-separated [list](http://docs.textmagictesting.com/#section/Lists) ID. Each contact must be assigned to at least one list.</value>
        [DataMember(Name="lists", EmitDefaultValue=false)]
        public string Lists { get; set; }

        /// <summary>
        /// Is the contact marked as favorite?
        /// </summary>
        /// <value>Is the contact marked as favorite?</value>
        [DataMember(Name="favorited", EmitDefaultValue=false)]
        public bool? Favorited { get; set; }

        /// <summary>
        /// Is the contact blocked for outgoing and incoming messaging?
        /// </summary>
        /// <value>Is the contact blocked for outgoing and incoming messaging?</value>
        [DataMember(Name="blocked", EmitDefaultValue=false)]
        public bool? Blocked { get; set; }

        /// <summary>
        /// Force type of phone. Possible values: 0 is landline; 1 is mobile; default is -1 (auto-detection).
        /// </summary>
        /// <value>Force type of phone. Possible values: 0 is landline; 1 is mobile; default is -1 (auto-detection).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or Sets CustomFieldValues
        /// </summary>
        [DataMember(Name="customFieldValues", EmitDefaultValue=false)]
        public List<CustomFieldListItem> CustomFieldValues { get; set; }

        /// <summary>
        /// Treat phone numbers passed in the request body as **local**.
        /// </summary>
        /// <value>Treat phone numbers passed in the request body as **local**.</value>
        [DataMember(Name="local", EmitDefaultValue=false)]
        public int? Local { get; set; }

        /// <summary>
        /// The 2-letter ISO country code for local phone numbers, used when **local** is set to true.
        /// </summary>
        /// <value>The 2-letter ISO country code for local phone numbers, used when **local** is set to true.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateContactInputObject {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Lists: ").Append(Lists).Append("\n");
            sb.Append("  Favorited: ").Append(Favorited).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CustomFieldValues: ").Append(CustomFieldValues).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as UpdateContactInputObject);
        }

        /// <summary>
        /// Returns true if UpdateContactInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateContactInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateContactInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Lists == input.Lists ||
                    (this.Lists != null &&
                    this.Lists.Equals(input.Lists))
                ) && 
                (
                    this.Favorited == input.Favorited ||
                    (this.Favorited != null &&
                    this.Favorited.Equals(input.Favorited))
                ) && 
                (
                    this.Blocked == input.Blocked ||
                    (this.Blocked != null &&
                    this.Blocked.Equals(input.Blocked))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CustomFieldValues == input.CustomFieldValues ||
                    this.CustomFieldValues != null &&
                    this.CustomFieldValues.SequenceEqual(input.CustomFieldValues)
                ) && 
                (
                    this.Local == input.Local ||
                    (this.Local != null &&
                    this.Local.Equals(input.Local))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Lists != null)
                    hashCode = hashCode * 59 + this.Lists.GetHashCode();
                if (this.Favorited != null)
                    hashCode = hashCode * 59 + this.Favorited.GetHashCode();
                if (this.Blocked != null)
                    hashCode = hashCode * 59 + this.Blocked.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CustomFieldValues != null)
                    hashCode = hashCode * 59 + this.CustomFieldValues.GetHashCode();
                if (this.Local != null)
                    hashCode = hashCode * 59 + this.Local.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
