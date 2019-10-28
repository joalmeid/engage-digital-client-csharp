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
    /// attributes in extra_infos are optional and unspecified/not guaranteed, don’t rely on it for critical tasks, this is provided as information only
    /// </summary>
    [DataContract]
    public partial class EventExtraInfo :  IEquatable<EventExtraInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventExtraInfo" /> class.
        /// </summary>
        /// <param name="authenticationStrategy">authenticationStrategy.</param>
        /// <param name="businessTimeSheetId">businessTimeSheetId.</param>
        /// <param name="categoryIds">categoryIds.</param>
        /// <param name="closedAutomatically">closedAutomatically.</param>
        /// <param name="contentId">contentId.</param>
        /// <param name="contentSourceId">contentSourceId.</param>
        /// <param name="contentThreadId">contentThreadId.</param>
        /// <param name="deferredDuration">deferredDuration.</param>
        /// <param name="deletions">deletions.</param>
        /// <param name="foreignId">can be null.</param>
        /// <param name="interventionId">interventionId.</param>
        /// <param name="requestIp">requestIp.</param>
        /// <param name="taskId">taskId.</param>
        /// <param name="userId">userId.</param>
        public EventExtraInfo(string authenticationStrategy = default(string), string businessTimeSheetId = default(string), List<string> categoryIds = default(List<string>), string closedAutomatically = default(string), string contentId = default(string), string contentSourceId = default(string), string contentThreadId = default(string), string deferredDuration = default(string), Object deletions = default(Object), string foreignId = default(string), string interventionId = default(string), string requestIp = default(string), string taskId = default(string), string userId = default(string))
        {
            this.AuthenticationStrategy = authenticationStrategy;
            this.BusinessTimeSheetId = businessTimeSheetId;
            this.CategoryIds = categoryIds;
            this.ClosedAutomatically = closedAutomatically;
            this.ContentId = contentId;
            this.ContentSourceId = contentSourceId;
            this.ContentThreadId = contentThreadId;
            this.DeferredDuration = deferredDuration;
            this.Deletions = deletions;
            this.ForeignId = foreignId;
            this.InterventionId = interventionId;
            this.RequestIp = requestIp;
            this.TaskId = taskId;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Gets or Sets AuthenticationStrategy
        /// </summary>
        [DataMember(Name="authentication_strategy", EmitDefaultValue=false)]
        public string AuthenticationStrategy { get; set; }

        /// <summary>
        /// Gets or Sets BusinessTimeSheetId
        /// </summary>
        [DataMember(Name="business/time_sheet_id", EmitDefaultValue=false)]
        public string BusinessTimeSheetId { get; set; }

        /// <summary>
        /// Gets or Sets CategoryIds
        /// </summary>
        [DataMember(Name="category_ids", EmitDefaultValue=false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// Gets or Sets ClosedAutomatically
        /// </summary>
        [DataMember(Name="closed_automatically", EmitDefaultValue=false)]
        public string ClosedAutomatically { get; set; }

        /// <summary>
        /// Gets or Sets ContentId
        /// </summary>
        [DataMember(Name="content_id", EmitDefaultValue=false)]
        public string ContentId { get; set; }

        /// <summary>
        /// Gets or Sets ContentSourceId
        /// </summary>
        [DataMember(Name="content_source_id", EmitDefaultValue=false)]
        public string ContentSourceId { get; set; }

        /// <summary>
        /// Gets or Sets ContentThreadId
        /// </summary>
        [DataMember(Name="content_thread_id", EmitDefaultValue=false)]
        public string ContentThreadId { get; set; }

        /// <summary>
        /// Gets or Sets DeferredDuration
        /// </summary>
        [DataMember(Name="deferred_duration", EmitDefaultValue=false)]
        public string DeferredDuration { get; set; }

        /// <summary>
        /// Gets or Sets Deletions
        /// </summary>
        [DataMember(Name="deletions", EmitDefaultValue=false)]
        public Object Deletions { get; set; }

        /// <summary>
        /// can be null
        /// </summary>
        /// <value>can be null</value>
        [DataMember(Name="foreign_id", EmitDefaultValue=false)]
        public string ForeignId { get; set; }

        /// <summary>
        /// Gets or Sets InterventionId
        /// </summary>
        [DataMember(Name="intervention_id", EmitDefaultValue=false)]
        public string InterventionId { get; set; }

        /// <summary>
        /// Gets or Sets RequestIp
        /// </summary>
        [DataMember(Name="request_ip", EmitDefaultValue=false)]
        public string RequestIp { get; set; }

        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name="task_id", EmitDefaultValue=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventExtraInfo {\n");
            sb.Append("  AuthenticationStrategy: ").Append(AuthenticationStrategy).Append("\n");
            sb.Append("  BusinessTimeSheetId: ").Append(BusinessTimeSheetId).Append("\n");
            sb.Append("  CategoryIds: ").Append(CategoryIds).Append("\n");
            sb.Append("  ClosedAutomatically: ").Append(ClosedAutomatically).Append("\n");
            sb.Append("  ContentId: ").Append(ContentId).Append("\n");
            sb.Append("  ContentSourceId: ").Append(ContentSourceId).Append("\n");
            sb.Append("  ContentThreadId: ").Append(ContentThreadId).Append("\n");
            sb.Append("  DeferredDuration: ").Append(DeferredDuration).Append("\n");
            sb.Append("  Deletions: ").Append(Deletions).Append("\n");
            sb.Append("  ForeignId: ").Append(ForeignId).Append("\n");
            sb.Append("  InterventionId: ").Append(InterventionId).Append("\n");
            sb.Append("  RequestIp: ").Append(RequestIp).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as EventExtraInfo);
        }

        /// <summary>
        /// Returns true if EventExtraInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EventExtraInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventExtraInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticationStrategy == input.AuthenticationStrategy ||
                    (this.AuthenticationStrategy != null &&
                    this.AuthenticationStrategy.Equals(input.AuthenticationStrategy))
                ) && 
                (
                    this.BusinessTimeSheetId == input.BusinessTimeSheetId ||
                    (this.BusinessTimeSheetId != null &&
                    this.BusinessTimeSheetId.Equals(input.BusinessTimeSheetId))
                ) && 
                (
                    this.CategoryIds == input.CategoryIds ||
                    this.CategoryIds != null &&
                    input.CategoryIds != null &&
                    this.CategoryIds.SequenceEqual(input.CategoryIds)
                ) && 
                (
                    this.ClosedAutomatically == input.ClosedAutomatically ||
                    (this.ClosedAutomatically != null &&
                    this.ClosedAutomatically.Equals(input.ClosedAutomatically))
                ) && 
                (
                    this.ContentId == input.ContentId ||
                    (this.ContentId != null &&
                    this.ContentId.Equals(input.ContentId))
                ) && 
                (
                    this.ContentSourceId == input.ContentSourceId ||
                    (this.ContentSourceId != null &&
                    this.ContentSourceId.Equals(input.ContentSourceId))
                ) && 
                (
                    this.ContentThreadId == input.ContentThreadId ||
                    (this.ContentThreadId != null &&
                    this.ContentThreadId.Equals(input.ContentThreadId))
                ) && 
                (
                    this.DeferredDuration == input.DeferredDuration ||
                    (this.DeferredDuration != null &&
                    this.DeferredDuration.Equals(input.DeferredDuration))
                ) && 
                (
                    this.Deletions == input.Deletions ||
                    (this.Deletions != null &&
                    this.Deletions.Equals(input.Deletions))
                ) && 
                (
                    this.ForeignId == input.ForeignId ||
                    (this.ForeignId != null &&
                    this.ForeignId.Equals(input.ForeignId))
                ) && 
                (
                    this.InterventionId == input.InterventionId ||
                    (this.InterventionId != null &&
                    this.InterventionId.Equals(input.InterventionId))
                ) && 
                (
                    this.RequestIp == input.RequestIp ||
                    (this.RequestIp != null &&
                    this.RequestIp.Equals(input.RequestIp))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AuthenticationStrategy != null)
                    hashCode = hashCode * 59 + this.AuthenticationStrategy.GetHashCode();
                if (this.BusinessTimeSheetId != null)
                    hashCode = hashCode * 59 + this.BusinessTimeSheetId.GetHashCode();
                if (this.CategoryIds != null)
                    hashCode = hashCode * 59 + this.CategoryIds.GetHashCode();
                if (this.ClosedAutomatically != null)
                    hashCode = hashCode * 59 + this.ClosedAutomatically.GetHashCode();
                if (this.ContentId != null)
                    hashCode = hashCode * 59 + this.ContentId.GetHashCode();
                if (this.ContentSourceId != null)
                    hashCode = hashCode * 59 + this.ContentSourceId.GetHashCode();
                if (this.ContentThreadId != null)
                    hashCode = hashCode * 59 + this.ContentThreadId.GetHashCode();
                if (this.DeferredDuration != null)
                    hashCode = hashCode * 59 + this.DeferredDuration.GetHashCode();
                if (this.Deletions != null)
                    hashCode = hashCode * 59 + this.Deletions.GetHashCode();
                if (this.ForeignId != null)
                    hashCode = hashCode * 59 + this.ForeignId.GetHashCode();
                if (this.InterventionId != null)
                    hashCode = hashCode * 59 + this.InterventionId.GetHashCode();
                if (this.RequestIp != null)
                    hashCode = hashCode * 59 + this.RequestIp.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
