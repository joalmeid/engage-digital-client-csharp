/* 
 * Engage Digital API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = RingCentral.EngageDigital.Client.SwaggerDateConverter;

namespace RingCentral.EngageDigital.Model
{
    /// <summary>
    /// Body
    /// </summary>
    [DataContract]
        internal partial class Body :  IEquatable<Body>
    {
        /// <summary>
        /// Defines Private
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                internal enum PrivateEnum
        {
            /// <summary>
            /// Enum True for value: true
            /// </summary>
            [EnumMember(Value = "true")]
            True = 0,
            /// <summary>
            /// Enum _1 for value: =1
            /// </summary>
            [EnumMember(Value = "=1")]
            _1 = 1        }
        /// <summary>
        /// Gets or Sets Private
        /// </summary>
        [DataMember(Name="private", EmitDefaultValue=false)]
        public PrivateEnum? Private { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        /// <param name="file">file.</param>
        /// <param name="_private">_private.</param>
        public Body(byte[] file = default(byte[]), PrivateEnum? _private = default(PrivateEnum?))
        {
            this.File = file;
            this.Private = _private;
        }
        
        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public byte[] File { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
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
            return this.Equals(input as Body);
        }

        /// <summary>
        /// Returns true if Body instances are equal
        /// </summary>
        /// <param name="input">Instance of Body to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Private == input.Private ||
                    (this.Private != null &&
                    this.Private.Equals(input.Private))
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
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Private != null)
                    hashCode = hashCode * 59 + this.Private.GetHashCode();
                return hashCode;
            }
        }
    }
}