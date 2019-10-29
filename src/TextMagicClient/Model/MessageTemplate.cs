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
    /// MessageTemplate
    /// </summary>
    [DataContract]
    public partial class MessageTemplate :  IEquatable<MessageTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageTemplate" /> class.
        /// </summary>
        /// <param name="id">Template ID. (required).</param>
        /// <param name="name">Template name. (required).</param>
        /// <param name="content">Template text. May contain tags inside braces. See the [Custom fields list](http://docs.textmagictesting.com/#section/Custom-fields-list-(Merge-tags)). (required).</param>
        /// <param name="lastModified">Time when the template was last modified. (required).</param>
        public MessageTemplate(int? id = default(int?), string name = default(string), string content = default(string), DateTime? lastModified = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MessageTemplate and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for MessageTemplate and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for MessageTemplate and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // to ensure "lastModified" is required (not null)
            if (lastModified == null)
            {
                throw new InvalidDataException("lastModified is a required property for MessageTemplate and cannot be null");
            }
            else
            {
                this.LastModified = lastModified;
            }
        }
        
        /// <summary>
        /// Template ID.
        /// </summary>
        /// <value>Template ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Template name.
        /// </summary>
        /// <value>Template name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Template text. May contain tags inside braces. See the [Custom fields list](http://docs.textmagictesting.com/#section/Custom-fields-list-(Merge-tags)).
        /// </summary>
        /// <value>Template text. May contain tags inside braces. See the [Custom fields list](http://docs.textmagictesting.com/#section/Custom-fields-list-(Merge-tags)).</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Time when the template was last modified.
        /// </summary>
        /// <value>Time when the template was last modified.</value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
            return this.Equals(input as MessageTemplate);
        }

        /// <summary>
        /// Returns true if MessageTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageTemplate input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
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
