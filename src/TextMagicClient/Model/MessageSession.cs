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
    /// MessageSession
    /// </summary>
    [DataContract]
    public partial class MessageSession :  IEquatable<MessageSession>, IValidatableObject
    {
        /// <summary>
        /// Destination type of a Message Session: * **t** – text SMS; * **s** – text-to-speech; * **v** – voice broadcast. 
        /// </summary>
        /// <value>Destination type of a Message Session: * **t** – text SMS; * **s** – text-to-speech; * **v** – voice broadcast. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DestinationEnum
        {
            
            /// <summary>
            /// Enum T for value: t
            /// </summary>
            [EnumMember(Value = "t")]
            T = 1,
            
            /// <summary>
            /// Enum S for value: s
            /// </summary>
            [EnumMember(Value = "s")]
            S = 2,
            
            /// <summary>
            /// Enum V for value: v
            /// </summary>
            [EnumMember(Value = "v")]
            V = 3
        }

        /// <summary>
        /// Destination type of a Message Session: * **t** – text SMS; * **s** – text-to-speech; * **v** – voice broadcast. 
        /// </summary>
        /// <value>Destination type of a Message Session: * **t** – text SMS; * **s** – text-to-speech; * **v** – voice broadcast. </value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public DestinationEnum Destination { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSession" /> class.
        /// </summary>
        /// <param name="id">Session ID. (required).</param>
        /// <param name="startTime">Session creation time. (required).</param>
        /// <param name="text">Session text. If a template was used for the session text (see [Messages: Send](https://docs.textmagic.com/#tag/Outbound-Messages) for details), it may contain template tags.  (required).</param>
        /// <param name="source">*   **O** – for TextMagic Online; *   **A** – for API; *   **M** – for TextMagic Messenger; *   **E** – for [Email to SMS](https://docs.textmagic.com/#tag/Send-Email-to-SMS); *   **X** – for [Distribution Lists](https://docs.textmagic.com/#tag/Distribution-Lists).  (required).</param>
        /// <param name="referenceId">Custom reference ID (see [Messages: Send](https://docs.textmagic.com/#tag/Send-Email-to-SMS) for details).  (required).</param>
        /// <param name="price">Session cost (in account currency). (required).</param>
        /// <param name="numbersCount">Session recipient count. (required).</param>
        /// <param name="destination">Destination type of a Message Session: * **t** – text SMS; * **s** – text-to-speech; * **v** – voice broadcast.  (required).</param>
        public MessageSession(int? id = default(int?), string startTime = default(string), string text = default(string), string source = default(string), string referenceId = default(string), decimal? price = default(decimal?), int? numbersCount = default(int?), DestinationEnum destination = default(DestinationEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MessageSession and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new InvalidDataException("startTime is a required property for MessageSession and cannot be null");
            }
            else
            {
                this.StartTime = startTime;
            }
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for MessageSession and cannot be null");
            }
            else
            {
                this.Text = text;
            }
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for MessageSession and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            // to ensure "referenceId" is required (not null)
            if (referenceId == null)
            {
                throw new InvalidDataException("referenceId is a required property for MessageSession and cannot be null");
            }
            else
            {
                this.ReferenceId = referenceId;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for MessageSession and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            // to ensure "numbersCount" is required (not null)
            if (numbersCount == null)
            {
                throw new InvalidDataException("numbersCount is a required property for MessageSession and cannot be null");
            }
            else
            {
                this.NumbersCount = numbersCount;
            }
            // to ensure "destination" is required (not null)
            if (destination == null)
            {
                throw new InvalidDataException("destination is a required property for MessageSession and cannot be null");
            }
            else
            {
                this.Destination = destination;
            }
        }
        
        /// <summary>
        /// Session ID.
        /// </summary>
        /// <value>Session ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Session creation time.
        /// </summary>
        /// <value>Session creation time.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Session text. If a template was used for the session text (see [Messages: Send](https://docs.textmagic.com/#tag/Outbound-Messages) for details), it may contain template tags. 
        /// </summary>
        /// <value>Session text. If a template was used for the session text (see [Messages: Send](https://docs.textmagic.com/#tag/Outbound-Messages) for details), it may contain template tags. </value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// *   **O** – for TextMagic Online; *   **A** – for API; *   **M** – for TextMagic Messenger; *   **E** – for [Email to SMS](https://docs.textmagic.com/#tag/Send-Email-to-SMS); *   **X** – for [Distribution Lists](https://docs.textmagic.com/#tag/Distribution-Lists). 
        /// </summary>
        /// <value>*   **O** – for TextMagic Online; *   **A** – for API; *   **M** – for TextMagic Messenger; *   **E** – for [Email to SMS](https://docs.textmagic.com/#tag/Send-Email-to-SMS); *   **X** – for [Distribution Lists](https://docs.textmagic.com/#tag/Distribution-Lists). </value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Custom reference ID (see [Messages: Send](https://docs.textmagic.com/#tag/Send-Email-to-SMS) for details). 
        /// </summary>
        /// <value>Custom reference ID (see [Messages: Send](https://docs.textmagic.com/#tag/Send-Email-to-SMS) for details). </value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Session cost (in account currency).
        /// </summary>
        /// <value>Session cost (in account currency).</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }

        /// <summary>
        /// Session recipient count.
        /// </summary>
        /// <value>Session recipient count.</value>
        [DataMember(Name="numbersCount", EmitDefaultValue=false)]
        public int? NumbersCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  NumbersCount: ").Append(NumbersCount).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
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
            return this.Equals(input as MessageSession);
        }

        /// <summary>
        /// Returns true if MessageSession instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.NumbersCount == input.NumbersCount ||
                    (this.NumbersCount != null &&
                    this.NumbersCount.Equals(input.NumbersCount))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.NumbersCount != null)
                    hashCode = hashCode * 59 + this.NumbersCount.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
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
