/* 
 * Engage Digital API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// IdentityGroup
    /// </summary>
    [DataContract]
    public partial class IdentityGroup :  IEquatable<IdentityGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IdentityGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityGroup" /> class.
        /// </summary>
        /// <param name="avatarUrl">avatarUrl.</param>
        /// <param name="company">company.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="customFieldValues">customFieldValues.</param>
        /// <param name="emails">emails.</param>
        /// <param name="firstname">firstname.</param>
        /// <param name="gender">gender.</param>
        /// <param name="homePhones">homePhones.</param>
        /// <param name="id">id (required).</param>
        /// <param name="identityIds">identityIds.</param>
        /// <param name="lastname">lastname.</param>
        /// <param name="mobilePhones">mobilePhones.</param>
        /// <param name="notes">notes.</param>
        /// <param name="tagIds">tagIds.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public IdentityGroup(string avatarUrl = default(string), string company = default(string), DateTime createdAt = default(DateTime), Object customFieldValues = default(Object), List<string> emails = default(List<string>), string firstname = default(string), string gender = default(string), List<string> homePhones = default(List<string>), string id = default(string), List<string> identityIds = default(List<string>), string lastname = default(string), List<string> mobilePhones = default(List<string>), string notes = default(string), List<string> tagIds = default(List<string>), DateTime updatedAt = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for IdentityGroup and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            this.AvatarUrl = avatarUrl;
            this.Company = company;
            this.CreatedAt = createdAt;
            this.CustomFieldValues = customFieldValues;
            this.Emails = emails;
            this.Firstname = firstname;
            this.Gender = gender;
            this.HomePhones = homePhones;
            this.IdentityIds = identityIds;
            this.Lastname = lastname;
            this.MobilePhones = mobilePhones;
            this.Notes = notes;
            this.TagIds = tagIds;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Gets or Sets AvatarUrl
        /// </summary>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CustomFieldValues
        /// </summary>
        [DataMember(Name="custom_field_values", EmitDefaultValue=false)]
        public Object CustomFieldValues { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Gets or Sets Firstname
        /// </summary>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets HomePhones
        /// </summary>
        [DataMember(Name="home_phones", EmitDefaultValue=false)]
        public List<string> HomePhones { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IdentityIds
        /// </summary>
        [DataMember(Name="identity_ids", EmitDefaultValue=false)]
        public List<string> IdentityIds { get; set; }

        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        /// <summary>
        /// Gets or Sets MobilePhones
        /// </summary>
        [DataMember(Name="mobile_phones", EmitDefaultValue=false)]
        public List<string> MobilePhones { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets TagIds
        /// </summary>
        [DataMember(Name="tag_ids", EmitDefaultValue=false)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityGroup {\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CustomFieldValues: ").Append(CustomFieldValues).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  HomePhones: ").Append(HomePhones).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdentityIds: ").Append(IdentityIds).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  MobilePhones: ").Append(MobilePhones).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as IdentityGroup);
        }

        /// <summary>
        /// Returns true if IdentityGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CustomFieldValues == input.CustomFieldValues ||
                    (this.CustomFieldValues != null &&
                    this.CustomFieldValues.Equals(input.CustomFieldValues))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.HomePhones == input.HomePhones ||
                    this.HomePhones != null &&
                    input.HomePhones != null &&
                    this.HomePhones.SequenceEqual(input.HomePhones)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IdentityIds == input.IdentityIds ||
                    this.IdentityIds != null &&
                    input.IdentityIds != null &&
                    this.IdentityIds.SequenceEqual(input.IdentityIds)
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.MobilePhones == input.MobilePhones ||
                    this.MobilePhones != null &&
                    input.MobilePhones != null &&
                    this.MobilePhones.SequenceEqual(input.MobilePhones)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.TagIds == input.TagIds ||
                    this.TagIds != null &&
                    input.TagIds != null &&
                    this.TagIds.SequenceEqual(input.TagIds)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CustomFieldValues != null)
                    hashCode = hashCode * 59 + this.CustomFieldValues.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.HomePhones != null)
                    hashCode = hashCode * 59 + this.HomePhones.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IdentityIds != null)
                    hashCode = hashCode * 59 + this.IdentityIds.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.MobilePhones != null)
                    hashCode = hashCode * 59 + this.MobilePhones.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.TagIds != null)
                    hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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