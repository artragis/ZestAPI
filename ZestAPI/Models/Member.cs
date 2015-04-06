using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZestAPI.Models
{
    /// <summary>
    /// Represents a member of Zeste de Savoir.
    /// </summary>
    public class Member
    {
        // Properties

        /// <summary>
        /// The ID of the member. It's unique.
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        /// The name of the member.
        /// </summary>
        [JsonProperty("username")]
        public string Name { get; set; }

        /// <summary>
        /// The email adress of the member.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Indicates if the member is in the staff
        /// </summary>
        [JsonProperty("is_staff")]
        public bool IsStaff { get; set; }

        /// <summary>
        /// TODO : Complete
        /// </summary>
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        /// <summary>
        /// The website of the member.
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// The URL of the Gravatar avatar of the member.
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// The biography of the member.
        /// </summary>
        [JsonProperty("biography")]
        public string Biography { get; set; }

        /// <summary>
        /// The sign of the member.
        /// </summary>
        [JsonProperty("sign")]
        public string Signature { get; set; }

        /// <summary>
        /// Indicates if the member allow to display is email to others.
        /// </summary>
        [JsonProperty("email_for_answer")]
        public bool AllowMailForAnswer { get; set; }

        /// <summary>
        /// The date of the last connexion of the member.
        /// </summary>
        [JsonProperty("last_visit")]
        public DateTime LastVisiteDate { get; set; }

        /// <summary>
        /// The date of inscription of the member.
        /// </summary>
        [JsonProperty("date_joined")]
        public DateTime JoinDate { get; set; }
    }
}
