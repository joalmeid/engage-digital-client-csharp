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
    /// TimeSheet
    /// </summary>
    [DataContract]
    public partial class TimeSheet :  IEquatable<TimeSheet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSheet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimeSheet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSheet" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="fridayHours">fridayHours.</param>
        /// <param name="holidays">holidays.</param>
        /// <param name="id">id (required).</param>
        /// <param name="label">label.</param>
        /// <param name="mondayHours">mondayHours.</param>
        /// <param name="saturdayHours">saturdayHours.</param>
        /// <param name="sourceIds">sourceIds.</param>
        /// <param name="sundayHours">sundayHours.</param>
        /// <param name="thursdayHours">thursdayHours.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="tuesdayHours">tuesdayHours.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="wednesdayHours">wednesdayHours.</param>
        public TimeSheet(bool active = default(bool), DateTime createdAt = default(DateTime), string fridayHours = default(string), List<TimeSheetHoliday> holidays = default(List<TimeSheetHoliday>), string id = default(string), string label = default(string), string mondayHours = default(string), string saturdayHours = default(string), List<string> sourceIds = default(List<string>), string sundayHours = default(string), string thursdayHours = default(string), string timezone = default(string), string tuesdayHours = default(string), DateTime updatedAt = default(DateTime), string wednesdayHours = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for TimeSheet and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            this.Active = active;
            this.CreatedAt = createdAt;
            this.FridayHours = fridayHours;
            this.Holidays = holidays;
            this.Label = label;
            this.MondayHours = mondayHours;
            this.SaturdayHours = saturdayHours;
            this.SourceIds = sourceIds;
            this.SundayHours = sundayHours;
            this.ThursdayHours = thursdayHours;
            this.Timezone = timezone;
            this.TuesdayHours = tuesdayHours;
            this.UpdatedAt = updatedAt;
            this.WednesdayHours = wednesdayHours;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets FridayHours
        /// </summary>
        [DataMember(Name="friday_hours", EmitDefaultValue=false)]
        public string FridayHours { get; set; }

        /// <summary>
        /// Gets or Sets Holidays
        /// </summary>
        [DataMember(Name="holidays[]", EmitDefaultValue=false)]
        public List<TimeSheetHoliday> Holidays { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets MondayHours
        /// </summary>
        [DataMember(Name="monday_hours", EmitDefaultValue=false)]
        public string MondayHours { get; set; }

        /// <summary>
        /// Gets or Sets SaturdayHours
        /// </summary>
        [DataMember(Name="saturday_hours", EmitDefaultValue=false)]
        public string SaturdayHours { get; set; }

        /// <summary>
        /// Gets or Sets SourceIds
        /// </summary>
        [DataMember(Name="source_ids", EmitDefaultValue=false)]
        public List<string> SourceIds { get; set; }

        /// <summary>
        /// Gets or Sets SundayHours
        /// </summary>
        [DataMember(Name="sunday_hours", EmitDefaultValue=false)]
        public string SundayHours { get; set; }

        /// <summary>
        /// Gets or Sets ThursdayHours
        /// </summary>
        [DataMember(Name="thursday_hours", EmitDefaultValue=false)]
        public string ThursdayHours { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets TuesdayHours
        /// </summary>
        [DataMember(Name="tuesday_hours", EmitDefaultValue=false)]
        public string TuesdayHours { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets WednesdayHours
        /// </summary>
        [DataMember(Name="wednesday_hours", EmitDefaultValue=false)]
        public string WednesdayHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSheet {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  FridayHours: ").Append(FridayHours).Append("\n");
            sb.Append("  Holidays: ").Append(Holidays).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  MondayHours: ").Append(MondayHours).Append("\n");
            sb.Append("  SaturdayHours: ").Append(SaturdayHours).Append("\n");
            sb.Append("  SourceIds: ").Append(SourceIds).Append("\n");
            sb.Append("  SundayHours: ").Append(SundayHours).Append("\n");
            sb.Append("  ThursdayHours: ").Append(ThursdayHours).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  TuesdayHours: ").Append(TuesdayHours).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  WednesdayHours: ").Append(WednesdayHours).Append("\n");
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
            return this.Equals(input as TimeSheet);
        }

        /// <summary>
        /// Returns true if TimeSheet instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeSheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSheet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.FridayHours == input.FridayHours ||
                    (this.FridayHours != null &&
                    this.FridayHours.Equals(input.FridayHours))
                ) && 
                (
                    this.Holidays == input.Holidays ||
                    this.Holidays != null &&
                    input.Holidays != null &&
                    this.Holidays.SequenceEqual(input.Holidays)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.MondayHours == input.MondayHours ||
                    (this.MondayHours != null &&
                    this.MondayHours.Equals(input.MondayHours))
                ) && 
                (
                    this.SaturdayHours == input.SaturdayHours ||
                    (this.SaturdayHours != null &&
                    this.SaturdayHours.Equals(input.SaturdayHours))
                ) && 
                (
                    this.SourceIds == input.SourceIds ||
                    this.SourceIds != null &&
                    input.SourceIds != null &&
                    this.SourceIds.SequenceEqual(input.SourceIds)
                ) && 
                (
                    this.SundayHours == input.SundayHours ||
                    (this.SundayHours != null &&
                    this.SundayHours.Equals(input.SundayHours))
                ) && 
                (
                    this.ThursdayHours == input.ThursdayHours ||
                    (this.ThursdayHours != null &&
                    this.ThursdayHours.Equals(input.ThursdayHours))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.TuesdayHours == input.TuesdayHours ||
                    (this.TuesdayHours != null &&
                    this.TuesdayHours.Equals(input.TuesdayHours))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.WednesdayHours == input.WednesdayHours ||
                    (this.WednesdayHours != null &&
                    this.WednesdayHours.Equals(input.WednesdayHours))
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
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.FridayHours != null)
                    hashCode = hashCode * 59 + this.FridayHours.GetHashCode();
                if (this.Holidays != null)
                    hashCode = hashCode * 59 + this.Holidays.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.MondayHours != null)
                    hashCode = hashCode * 59 + this.MondayHours.GetHashCode();
                if (this.SaturdayHours != null)
                    hashCode = hashCode * 59 + this.SaturdayHours.GetHashCode();
                if (this.SourceIds != null)
                    hashCode = hashCode * 59 + this.SourceIds.GetHashCode();
                if (this.SundayHours != null)
                    hashCode = hashCode * 59 + this.SundayHours.GetHashCode();
                if (this.ThursdayHours != null)
                    hashCode = hashCode * 59 + this.ThursdayHours.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.TuesdayHours != null)
                    hashCode = hashCode * 59 + this.TuesdayHours.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.WednesdayHours != null)
                    hashCode = hashCode * 59 + this.WednesdayHours.GetHashCode();
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