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
    /// Content
    /// </summary>
    [DataContract]
        public partial class Content :  IEquatable<Content>
    {
        /// <summary>
        /// values can be: text or html.
        /// </summary>
        /// <value>values can be: text or html.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum BodyInputFormatEnum
        {
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 0,
            /// <summary>
            /// Enum Html for value: html
            /// </summary>
            [EnumMember(Value = "html")]
            Html = 1        }
        /// <summary>
        /// values can be: text or html.
        /// </summary>
        /// <value>values can be: text or html.</value>
        [DataMember(Name="body_input_format", EmitDefaultValue=false)]
        public BodyInputFormatEnum? BodyInputFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Content" /> class.
        /// </summary>
        /// <param name="approvalRequired">approvalRequired.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="attachmentsCount">attachmentsCount.</param>
        /// <param name="authorId">authorId.</param>
        /// <param name="body">body.</param>
        /// <param name="bodyFormatted">bodyFormatted.</param>
        /// <param name="bodyInputFormat">values can be: text or html..</param>
        /// <param name="categoryIds">are content categories if none, they are default to intervention categories or thread categories.</param>
        /// <param name="contextData">is present only if the content has context_data associated. The context_data hash keys are the custom fields keys..</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="createdFrom">createdFrom.</param>
        /// <param name="creatorId">creatorId.</param>
        /// <param name="foreignId">foreignId.</param>
        /// <param name="id">id (required).</param>
        /// <param name="inReplyToAuthorId">inReplyToAuthorId.</param>
        /// <param name="inReplyToId">inReplyToId.</param>
        /// <param name="interventionId">interventionId.</param>
        /// <param name="language">language.</param>
        /// <param name="privateMessage">privateMessage.</param>
        /// <param name="published">published.</param>
        /// <param name="remotelyDeleted">remotelyDeleted.</param>
        /// <param name="sourceId">sourceId.</param>
        /// <param name="sourceType">sourceType.</param>
        /// <param name="sourceUrl">sourceUrl.</param>
        /// <param name="status">status.</param>
        /// <param name="synchronizationStatus">synchronizationStatus.</param>
        /// <param name="threadId">threadId.</param>
        /// <param name="title">title.</param>
        /// <param name="type">type.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public Content(bool? approvalRequired = default(bool?), List<ContentAttachment> attachments = default(List<ContentAttachment>), int? attachmentsCount = default(int?), string authorId = default(string), string body = default(string), ContentBodyFormatted bodyFormatted = default(ContentBodyFormatted), BodyInputFormatEnum? bodyInputFormat = default(BodyInputFormatEnum?), List<string> categoryIds = default(List<string>), Object contextData = default(Object), DateTimeOffset? createdAt = default(DateTimeOffset?), string createdFrom = default(string), string creatorId = default(string), string foreignId = default(string), string id = default(string), string inReplyToAuthorId = default(string), string inReplyToId = default(string), string interventionId = default(string), string language = default(string), bool? privateMessage = default(bool?), bool? published = default(bool?), bool? remotelyDeleted = default(bool?), string sourceId = default(string), string sourceType = default(string), string sourceUrl = default(string), string status = default(string), string synchronizationStatus = default(string), string threadId = default(string), string title = default(string), string type = default(string), DateTimeOffset? updatedAt = default(DateTimeOffset?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Content and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            this.ApprovalRequired = approvalRequired;
            this.Attachments = attachments;
            this.AttachmentsCount = attachmentsCount;
            this.AuthorId = authorId;
            this.Body = body;
            this.BodyFormatted = bodyFormatted;
            this.BodyInputFormat = bodyInputFormat;
            this.CategoryIds = categoryIds;
            this.ContextData = contextData;
            this.CreatedAt = createdAt;
            this.CreatedFrom = createdFrom;
            this.CreatorId = creatorId;
            this.ForeignId = foreignId;
            this.InReplyToAuthorId = inReplyToAuthorId;
            this.InReplyToId = inReplyToId;
            this.InterventionId = interventionId;
            this.Language = language;
            this.PrivateMessage = privateMessage;
            this.Published = published;
            this.RemotelyDeleted = remotelyDeleted;
            this.SourceId = sourceId;
            this.SourceType = sourceType;
            this.SourceUrl = sourceUrl;
            this.Status = status;
            this.SynchronizationStatus = synchronizationStatus;
            this.ThreadId = threadId;
            this.Title = title;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Gets or Sets ApprovalRequired
        /// </summary>
        [DataMember(Name="approval_required", EmitDefaultValue=false)]
        public bool? ApprovalRequired { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<ContentAttachment> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentsCount
        /// </summary>
        [DataMember(Name="attachments_count", EmitDefaultValue=false)]
        public int? AttachmentsCount { get; set; }

        /// <summary>
        /// Gets or Sets AuthorId
        /// </summary>
        [DataMember(Name="author_id", EmitDefaultValue=false)]
        public string AuthorId { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets BodyFormatted
        /// </summary>
        [DataMember(Name="body_formatted", EmitDefaultValue=false)]
        public ContentBodyFormatted BodyFormatted { get; set; }


        /// <summary>
        /// are content categories if none, they are default to intervention categories or thread categories
        /// </summary>
        /// <value>are content categories if none, they are default to intervention categories or thread categories</value>
        [DataMember(Name="category_ids", EmitDefaultValue=false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// is present only if the content has context_data associated. The context_data hash keys are the custom fields keys.
        /// </summary>
        /// <value>is present only if the content has context_data associated. The context_data hash keys are the custom fields keys.</value>
        [DataMember(Name="context_data", EmitDefaultValue=false)]
        public Object ContextData { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedFrom
        /// </summary>
        [DataMember(Name="created_from", EmitDefaultValue=false)]
        public string CreatedFrom { get; set; }

        /// <summary>
        /// Gets or Sets CreatorId
        /// </summary>
        [DataMember(Name="creator_id", EmitDefaultValue=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// Gets or Sets ForeignId
        /// </summary>
        [DataMember(Name="foreign_id", EmitDefaultValue=false)]
        public string ForeignId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InReplyToAuthorId
        /// </summary>
        [DataMember(Name="in_reply_to_author_id", EmitDefaultValue=false)]
        public string InReplyToAuthorId { get; set; }

        /// <summary>
        /// Gets or Sets InReplyToId
        /// </summary>
        [DataMember(Name="in_reply_to_id", EmitDefaultValue=false)]
        public string InReplyToId { get; set; }

        /// <summary>
        /// Gets or Sets InterventionId
        /// </summary>
        [DataMember(Name="intervention_id", EmitDefaultValue=false)]
        public string InterventionId { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets PrivateMessage
        /// </summary>
        [DataMember(Name="private_message", EmitDefaultValue=false)]
        public bool? PrivateMessage { get; set; }

        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// Gets or Sets RemotelyDeleted
        /// </summary>
        [DataMember(Name="remotely_deleted", EmitDefaultValue=false)]
        public bool? RemotelyDeleted { get; set; }

        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name="source_id", EmitDefaultValue=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name="source_type", EmitDefaultValue=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// Gets or Sets SourceUrl
        /// </summary>
        [DataMember(Name="source_url", EmitDefaultValue=false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SynchronizationStatus
        /// </summary>
        [DataMember(Name="synchronization_status", EmitDefaultValue=false)]
        public string SynchronizationStatus { get; set; }

        /// <summary>
        /// Gets or Sets ThreadId
        /// </summary>
        [DataMember(Name="thread_id", EmitDefaultValue=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Content {\n");
            sb.Append("  ApprovalRequired: ").Append(ApprovalRequired).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  AttachmentsCount: ").Append(AttachmentsCount).Append("\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyFormatted: ").Append(BodyFormatted).Append("\n");
            sb.Append("  BodyInputFormat: ").Append(BodyInputFormat).Append("\n");
            sb.Append("  CategoryIds: ").Append(CategoryIds).Append("\n");
            sb.Append("  ContextData: ").Append(ContextData).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedFrom: ").Append(CreatedFrom).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  ForeignId: ").Append(ForeignId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InReplyToAuthorId: ").Append(InReplyToAuthorId).Append("\n");
            sb.Append("  InReplyToId: ").Append(InReplyToId).Append("\n");
            sb.Append("  InterventionId: ").Append(InterventionId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  PrivateMessage: ").Append(PrivateMessage).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  RemotelyDeleted: ").Append(RemotelyDeleted).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceUrl: ").Append(SourceUrl).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SynchronizationStatus: ").Append(SynchronizationStatus).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Content);
        }

        /// <summary>
        /// Returns true if Content instances are equal
        /// </summary>
        /// <param name="input">Instance of Content to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Content input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApprovalRequired == input.ApprovalRequired ||
                    (this.ApprovalRequired != null &&
                    this.ApprovalRequired.Equals(input.ApprovalRequired))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.AttachmentsCount == input.AttachmentsCount ||
                    (this.AttachmentsCount != null &&
                    this.AttachmentsCount.Equals(input.AttachmentsCount))
                ) && 
                (
                    this.AuthorId == input.AuthorId ||
                    (this.AuthorId != null &&
                    this.AuthorId.Equals(input.AuthorId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.BodyFormatted == input.BodyFormatted ||
                    (this.BodyFormatted != null &&
                    this.BodyFormatted.Equals(input.BodyFormatted))
                ) && 
                (
                    this.BodyInputFormat == input.BodyInputFormat ||
                    (this.BodyInputFormat != null &&
                    this.BodyInputFormat.Equals(input.BodyInputFormat))
                ) && 
                (
                    this.CategoryIds == input.CategoryIds ||
                    this.CategoryIds != null &&
                    input.CategoryIds != null &&
                    this.CategoryIds.SequenceEqual(input.CategoryIds)
                ) && 
                (
                    this.ContextData == input.ContextData ||
                    (this.ContextData != null &&
                    this.ContextData.Equals(input.ContextData))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedFrom == input.CreatedFrom ||
                    (this.CreatedFrom != null &&
                    this.CreatedFrom.Equals(input.CreatedFrom))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.ForeignId == input.ForeignId ||
                    (this.ForeignId != null &&
                    this.ForeignId.Equals(input.ForeignId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InReplyToAuthorId == input.InReplyToAuthorId ||
                    (this.InReplyToAuthorId != null &&
                    this.InReplyToAuthorId.Equals(input.InReplyToAuthorId))
                ) && 
                (
                    this.InReplyToId == input.InReplyToId ||
                    (this.InReplyToId != null &&
                    this.InReplyToId.Equals(input.InReplyToId))
                ) && 
                (
                    this.InterventionId == input.InterventionId ||
                    (this.InterventionId != null &&
                    this.InterventionId.Equals(input.InterventionId))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.PrivateMessage == input.PrivateMessage ||
                    (this.PrivateMessage != null &&
                    this.PrivateMessage.Equals(input.PrivateMessage))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.RemotelyDeleted == input.RemotelyDeleted ||
                    (this.RemotelyDeleted != null &&
                    this.RemotelyDeleted.Equals(input.RemotelyDeleted))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.SourceUrl == input.SourceUrl ||
                    (this.SourceUrl != null &&
                    this.SourceUrl.Equals(input.SourceUrl))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SynchronizationStatus == input.SynchronizationStatus ||
                    (this.SynchronizationStatus != null &&
                    this.SynchronizationStatus.Equals(input.SynchronizationStatus))
                ) && 
                (
                    this.ThreadId == input.ThreadId ||
                    (this.ThreadId != null &&
                    this.ThreadId.Equals(input.ThreadId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ApprovalRequired != null)
                    hashCode = hashCode * 59 + this.ApprovalRequired.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.AttachmentsCount != null)
                    hashCode = hashCode * 59 + this.AttachmentsCount.GetHashCode();
                if (this.AuthorId != null)
                    hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.BodyFormatted != null)
                    hashCode = hashCode * 59 + this.BodyFormatted.GetHashCode();
                if (this.BodyInputFormat != null)
                    hashCode = hashCode * 59 + this.BodyInputFormat.GetHashCode();
                if (this.CategoryIds != null)
                    hashCode = hashCode * 59 + this.CategoryIds.GetHashCode();
                if (this.ContextData != null)
                    hashCode = hashCode * 59 + this.ContextData.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedFrom != null)
                    hashCode = hashCode * 59 + this.CreatedFrom.GetHashCode();
                if (this.CreatorId != null)
                    hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.ForeignId != null)
                    hashCode = hashCode * 59 + this.ForeignId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InReplyToAuthorId != null)
                    hashCode = hashCode * 59 + this.InReplyToAuthorId.GetHashCode();
                if (this.InReplyToId != null)
                    hashCode = hashCode * 59 + this.InReplyToId.GetHashCode();
                if (this.InterventionId != null)
                    hashCode = hashCode * 59 + this.InterventionId.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.PrivateMessage != null)
                    hashCode = hashCode * 59 + this.PrivateMessage.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.RemotelyDeleted != null)
                    hashCode = hashCode * 59 + this.RemotelyDeleted.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.SourceUrl != null)
                    hashCode = hashCode * 59 + this.SourceUrl.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SynchronizationStatus != null)
                    hashCode = hashCode * 59 + this.SynchronizationStatus.GetHashCode();
                if (this.ThreadId != null)
                    hashCode = hashCode * 59 + this.ThreadId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
