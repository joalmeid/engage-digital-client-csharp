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
using OpenAPIDateConverter = RingCentral.EngageDigital.Client.OpenAPIDateConverter;

namespace RingCentral.EngageDigital.Model
{
    /// <summary>
    /// GetAllAttachmentsResponse
    /// </summary>
    [DataContract]
    public partial class GetAllAttachmentsResponse :  IEquatable<GetAllAttachmentsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllAttachmentsResponse" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="limit">limit.</param>
        /// <param name="offset">offset.</param>
        /// <param name="records">records.</param>
        public GetAllAttachmentsResponse(int count = default(int), int limit = default(int), int offset = default(int), Collection<Attachment> records = default(Collection<Attachment>))
        {
            this.Count = count;
            this.Limit = limit;
            this.Offset = offset;
            this.Records = records;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public Collection<Attachment> Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAllAttachmentsResponse {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(input as GetAllAttachmentsResponse);
        }

        /// <summary>
        /// Returns true if GetAllAttachmentsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAllAttachmentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAllAttachmentsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Offset == input.Offset ||
                    this.Offset.Equals(input.Offset)
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
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
                hashCode = hashCode * 59 + this.Count.GetHashCode();
                hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Records != null)
                    hashCode = hashCode * 59 + this.Records.GetHashCode();
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
