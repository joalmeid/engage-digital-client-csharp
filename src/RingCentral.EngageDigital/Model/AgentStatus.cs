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
    /// AgentStatus
    /// </summary>
    [DataContract]
    public partial class AgentStatus :  IEquatable<AgentStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatus" /> class.
        /// </summary>
        /// <param name="agentId">agentId.</param>
        /// <param name="channels">channels.</param>
        /// <param name="customStatus">customStatus.</param>
        public AgentStatus(string agentId = default(string), Collection<AgentStatusChannel> channels = default(Collection<AgentStatusChannel>), AgentCustomStatus customStatus = default(AgentCustomStatus))
        {
            this.AgentId = agentId;
            this.Channels = channels;
            this.CustomStatus = customStatus;
        }
        
        /// <summary>
        /// Gets or Sets AgentId
        /// </summary>
        [DataMember(Name="agent_id", EmitDefaultValue=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// Gets or Sets Channels
        /// </summary>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public Collection<AgentStatusChannel> Channels { get; set; }

        /// <summary>
        /// Gets or Sets CustomStatus
        /// </summary>
        [DataMember(Name="custom_status", EmitDefaultValue=false)]
        public AgentCustomStatus CustomStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentStatus {\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  CustomStatus: ").Append(CustomStatus).Append("\n");
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
            return this.Equals(input as AgentStatus);
        }

        /// <summary>
        /// Returns true if AgentStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of AgentStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.Channels == input.Channels ||
                    this.Channels != null &&
                    input.Channels != null &&
                    this.Channels.SequenceEqual(input.Channels)
                ) && 
                (
                    this.CustomStatus == input.CustomStatus ||
                    (this.CustomStatus != null &&
                    this.CustomStatus.Equals(input.CustomStatus))
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
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.CustomStatus != null)
                    hashCode = hashCode * 59 + this.CustomStatus.GetHashCode();
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
