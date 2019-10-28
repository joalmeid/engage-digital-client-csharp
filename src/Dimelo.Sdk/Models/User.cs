using Newtonsoft.Json;
using System.ComponentModel;

namespace Dimelo.Sdk.Models
{
    public class User : Base
    {
        /// <summary>
        /// Firstname of the user if you can provide it.
        /// </summary>
        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        /// <summary>
        /// Lastname of the user if you can provide it.
        /// </summary>
        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// Required. Name we display for this user.
        /// </summary>
        [JsonRequired]
        [JsonProperty("screenname")]
        public string Screenname { get; set; }

        /// <summary>
        /// Avatar Url of the user if you can provide it.
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Confirmed email of the user, can be used to send email PM if no PM mechanism is supported.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Home phone number.
        /// </summary>
        [JsonProperty("home_phone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// Mobile phone number.
        /// </summary>
        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Whether Engage Digital can use this user as identity to create message. False by default.
        /// </summary>
        [DefaultValue(false)]
        [JsonProperty("puppetizable")]
        public bool Puppetizable { get; set; }

        /// <summary>
        /// Accepted values are "man" or "woman"
        /// </summary>
        [JsonProperty("gender")]
        public Gender Gender { get; set; }
    }
}


