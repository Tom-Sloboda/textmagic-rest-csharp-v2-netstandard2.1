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
    /// Contact
    /// </summary>
    [DataContract]
    public partial class Contact :  IEquatable<Contact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Contact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="id">Contact ID. (required).</param>
        /// <param name="favorited">Is the Contact favorite? [Favorite list](http://docs.textmagictesting.com/#operation/getFavorites). (required).</param>
        /// <param name="blocked">Is the Contact blocked? [Blocked contacts](http://docs.textmagictesting.com/#operation/getBlockedContacts). (required).</param>
        /// <param name="firstName">Contact first name. (required).</param>
        /// <param name="lastName">Contact last name. (required).</param>
        /// <param name="companyName">Company name. (required).</param>
        /// <param name="phone">Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164). (required).</param>
        /// <param name="email">Contact email address. (required).</param>
        /// <param name="country">Contact country. (required).</param>
        /// <param name="customFields">See the [Custom Fields](http://docs.textmagictesting.com/#tag/Custom-Fields) section. (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="lists">lists (required).</param>
        /// <param name="phoneType">Phone number type: * **0** if it is fixed-line; * **1** if it is mobile; * **2** if it is mobile or fixed-line (in case we cannot distingush between fixed-line or mobile); * **3** if it is toll-free; * **4** if it is a premium rate phone; * **5** if it is a shared cost phone; * **6** if it is a VoIP; * **7** if it is a [Personal Number](); * **8** if it is a pager; * **9** if it is a Universal Access Number; * **10** if the phone type is unknown; * **-1** if the phone type is not yet processed or cannot be determined.  (required).</param>
        /// <param name="avatar">avatar (required).</param>
        /// <param name="notes">notes (required).</param>
        public Contact(int? id = default(int?), bool? favorited = default(bool?), bool? blocked = default(bool?), string firstName = default(string), string lastName = default(string), string companyName = default(string), string phone = default(string), string email = default(string), Country country = default(Country), List<ContactCustomField> customFields = default(List<ContactCustomField>), User user = default(User), List<List> lists = default(List<List>), string phoneType = default(string), ContactImage avatar = default(ContactImage), List<ContactNote> notes = default(List<ContactNote>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Contact and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "favorited" is required (not null)
            if (favorited == null)
            {
                throw new InvalidDataException("favorited is a required property for Contact and cannot be null");
            }
            else
            {
                this.Favorited = favorited;
            }
            // to ensure "blocked" is required (not null)
            if (blocked == null)
            {
                throw new InvalidDataException("blocked is a required property for Contact and cannot be null");
            }
            else
            {
                this.Blocked = blocked;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for Contact and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for Contact and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }
            // to ensure "companyName" is required (not null)
            if (companyName == null)
            {
                throw new InvalidDataException("companyName is a required property for Contact and cannot be null");
            }
            else
            {
                this.CompanyName = companyName;
            }
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new InvalidDataException("phone is a required property for Contact and cannot be null");
            }
            else
            {
                this.Phone = phone;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for Contact and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for Contact and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            // to ensure "customFields" is required (not null)
            if (customFields == null)
            {
                throw new InvalidDataException("customFields is a required property for Contact and cannot be null");
            }
            else
            {
                this.CustomFields = customFields;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for Contact and cannot be null");
            }
            else
            {
                this.User = user;
            }
            // to ensure "lists" is required (not null)
            if (lists == null)
            {
                throw new InvalidDataException("lists is a required property for Contact and cannot be null");
            }
            else
            {
                this.Lists = lists;
            }
            // to ensure "phoneType" is required (not null)
            if (phoneType == null)
            {
                throw new InvalidDataException("phoneType is a required property for Contact and cannot be null");
            }
            else
            {
                this.PhoneType = phoneType;
            }
            // to ensure "avatar" is required (not null)
            if (avatar == null)
            {
                throw new InvalidDataException("avatar is a required property for Contact and cannot be null");
            }
            else
            {
                this.Avatar = avatar;
            }
            // to ensure "notes" is required (not null)
            if (notes == null)
            {
                throw new InvalidDataException("notes is a required property for Contact and cannot be null");
            }
            else
            {
                this.Notes = notes;
            }
        }
        
        /// <summary>
        /// Contact ID.
        /// </summary>
        /// <value>Contact ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Is the Contact favorite? [Favorite list](http://docs.textmagictesting.com/#operation/getFavorites).
        /// </summary>
        /// <value>Is the Contact favorite? [Favorite list](http://docs.textmagictesting.com/#operation/getFavorites).</value>
        [DataMember(Name="favorited", EmitDefaultValue=false)]
        public bool? Favorited { get; set; }

        /// <summary>
        /// Is the Contact blocked? [Blocked contacts](http://docs.textmagictesting.com/#operation/getBlockedContacts).
        /// </summary>
        /// <value>Is the Contact blocked? [Blocked contacts](http://docs.textmagictesting.com/#operation/getBlockedContacts).</value>
        [DataMember(Name="blocked", EmitDefaultValue=false)]
        public bool? Blocked { get; set; }

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
        /// Company name.
        /// </summary>
        /// <value>Company name.</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

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
        /// Contact country.
        /// </summary>
        /// <value>Contact country.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public Country Country { get; set; }

        /// <summary>
        /// See the [Custom Fields](http://docs.textmagictesting.com/#tag/Custom-Fields) section.
        /// </summary>
        /// <value>See the [Custom Fields](http://docs.textmagictesting.com/#tag/Custom-Fields) section.</value>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public List<ContactCustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets Lists
        /// </summary>
        [DataMember(Name="lists", EmitDefaultValue=false)]
        public List<List> Lists { get; set; }

        /// <summary>
        /// Phone number type: * **0** if it is fixed-line; * **1** if it is mobile; * **2** if it is mobile or fixed-line (in case we cannot distingush between fixed-line or mobile); * **3** if it is toll-free; * **4** if it is a premium rate phone; * **5** if it is a shared cost phone; * **6** if it is a VoIP; * **7** if it is a [Personal Number](); * **8** if it is a pager; * **9** if it is a Universal Access Number; * **10** if the phone type is unknown; * **-1** if the phone type is not yet processed or cannot be determined. 
        /// </summary>
        /// <value>Phone number type: * **0** if it is fixed-line; * **1** if it is mobile; * **2** if it is mobile or fixed-line (in case we cannot distingush between fixed-line or mobile); * **3** if it is toll-free; * **4** if it is a premium rate phone; * **5** if it is a shared cost phone; * **6** if it is a VoIP; * **7** if it is a [Personal Number](); * **8** if it is a pager; * **9** if it is a Universal Access Number; * **10** if the phone type is unknown; * **-1** if the phone type is not yet processed or cannot be determined. </value>
        [DataMember(Name="phoneType", EmitDefaultValue=false)]
        public string PhoneType { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public ContactImage Avatar { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public List<ContactNote> Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Favorited: ").Append(Favorited).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Lists: ").Append(Lists).Append("\n");
            sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="input">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact input)
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
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
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
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Lists == input.Lists ||
                    this.Lists != null &&
                    this.Lists.SequenceEqual(input.Lists)
                ) && 
                (
                    this.PhoneType == input.PhoneType ||
                    (this.PhoneType != null &&
                    this.PhoneType.Equals(input.PhoneType))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
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
                if (this.Favorited != null)
                    hashCode = hashCode * 59 + this.Favorited.GetHashCode();
                if (this.Blocked != null)
                    hashCode = hashCode * 59 + this.Blocked.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Lists != null)
                    hashCode = hashCode * 59 + this.Lists.GetHashCode();
                if (this.PhoneType != null)
                    hashCode = hashCode * 59 + this.PhoneType.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
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
