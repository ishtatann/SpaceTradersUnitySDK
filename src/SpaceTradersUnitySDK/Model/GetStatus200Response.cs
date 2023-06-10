/*
 * SpaceTraders API
 *
 * SpaceTraders is an open-universe game and learning platform that offers a set of HTTP endpoints to control a fleet of ships and explore a multiplayer universe.  The API is documented using [OpenAPI](https://github.com/SpaceTradersAPI/api-docs). You can send your first request right here in your browser to check the status of the game server.  ```json http {   \"method\": \"GET\",   \"url\": \"https://api.spacetraders.io/v2\", } ```  Unlike a traditional game, SpaceTraders does not have a first-party client or app to play the game. Instead, you can use the API to build your own client, write a script to automate your ships, or try an app built by the community.  We have a [Discord channel](https://discord.com/invite/jh6zurdWk5) where you can share your projects, ask questions, and get help from other players.   
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: joel@spacetraders.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = SpaceTradersUnitySDK.Client.OpenAPIDateConverter;

namespace SpaceTradersUnitySDK.Model
{
    /// <summary>
    /// GetStatus200Response
    /// </summary>
    [DataContract(Name = "get_status_200_response")]
    public partial class GetStatus200Response : IEquatable<GetStatus200Response>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatus200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetStatus200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatus200Response" /> class.
        /// </summary>
        /// <param name="status">The current status of the game server. (required).</param>
        /// <param name="version">The current version of the API. (required).</param>
        /// <param name="resetDate">The date and time when the game server was last reset. (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="stats">stats (required).</param>
        /// <param name="leaderboards">leaderboards (required).</param>
        /// <param name="serverResets">serverResets (required).</param>
        /// <param name="announcements">announcements (required).</param>
        /// <param name="links">links (required).</param>
        public GetStatus200Response(string status = default(string), string version = default(string), string resetDate = default(string), string description = default(string), GetStatus200ResponseStats stats = default(GetStatus200ResponseStats), GetStatus200ResponseLeaderboards leaderboards = default(GetStatus200ResponseLeaderboards), GetStatus200ResponseServerResets serverResets = default(GetStatus200ResponseServerResets), List<GetStatus200ResponseAnnouncementsInner> announcements = default(List<GetStatus200ResponseAnnouncementsInner>), List<GetStatus200ResponseLinksInner> links = default(List<GetStatus200ResponseLinksInner>))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for GetStatus200Response and cannot be null");
            }
            this.Status = status;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new ArgumentNullException("version is a required property for GetStatus200Response and cannot be null");
            }
            this._Version = version;
            // to ensure "resetDate" is required (not null)
            if (resetDate == null)
            {
                throw new ArgumentNullException("resetDate is a required property for GetStatus200Response and cannot be null");
            }
            this.ResetDate = resetDate;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for GetStatus200Response and cannot be null");
            }
            this.Description = description;
            // to ensure "stats" is required (not null)
            if (stats == null)
            {
                throw new ArgumentNullException("stats is a required property for GetStatus200Response and cannot be null");
            }
            this.Stats = stats;
            // to ensure "leaderboards" is required (not null)
            if (leaderboards == null)
            {
                throw new ArgumentNullException("leaderboards is a required property for GetStatus200Response and cannot be null");
            }
            this.Leaderboards = leaderboards;
            // to ensure "serverResets" is required (not null)
            if (serverResets == null)
            {
                throw new ArgumentNullException("serverResets is a required property for GetStatus200Response and cannot be null");
            }
            this.ServerResets = serverResets;
            // to ensure "announcements" is required (not null)
            if (announcements == null)
            {
                throw new ArgumentNullException("announcements is a required property for GetStatus200Response and cannot be null");
            }
            this.Announcements = announcements;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for GetStatus200Response and cannot be null");
            }
            this.Links = links;
        }

        /// <summary>
        /// The current status of the game server.
        /// </summary>
        /// <value>The current status of the game server.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// The current version of the API.
        /// </summary>
        /// <value>The current version of the API.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string _Version { get; set; }

        /// <summary>
        /// The date and time when the game server was last reset.
        /// </summary>
        /// <value>The date and time when the game server was last reset.</value>
        [DataMember(Name = "resetDate", IsRequired = true, EmitDefaultValue = true)]
        public string ResetDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", IsRequired = true, EmitDefaultValue = true)]
        public GetStatus200ResponseStats Stats { get; set; }

        /// <summary>
        /// Gets or Sets Leaderboards
        /// </summary>
        [DataMember(Name = "leaderboards", IsRequired = true, EmitDefaultValue = true)]
        public GetStatus200ResponseLeaderboards Leaderboards { get; set; }

        /// <summary>
        /// Gets or Sets ServerResets
        /// </summary>
        [DataMember(Name = "serverResets", IsRequired = true, EmitDefaultValue = true)]
        public GetStatus200ResponseServerResets ServerResets { get; set; }

        /// <summary>
        /// Gets or Sets Announcements
        /// </summary>
        [DataMember(Name = "announcements", IsRequired = true, EmitDefaultValue = true)]
        public List<GetStatus200ResponseAnnouncementsInner> Announcements { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public List<GetStatus200ResponseLinksInner> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetStatus200Response {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  ResetDate: ").Append(ResetDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Leaderboards: ").Append(Leaderboards).Append("\n");
            sb.Append("  ServerResets: ").Append(ServerResets).Append("\n");
            sb.Append("  Announcements: ").Append(Announcements).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetStatus200Response);
        }

        /// <summary>
        /// Returns true if GetStatus200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStatus200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStatus200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.ResetDate == input.ResetDate ||
                    (this.ResetDate != null &&
                    this.ResetDate.Equals(input.ResetDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Leaderboards == input.Leaderboards ||
                    (this.Leaderboards != null &&
                    this.Leaderboards.Equals(input.Leaderboards))
                ) && 
                (
                    this.ServerResets == input.ServerResets ||
                    (this.ServerResets != null &&
                    this.ServerResets.Equals(input.ServerResets))
                ) && 
                (
                    this.Announcements == input.Announcements ||
                    this.Announcements != null &&
                    input.Announcements != null &&
                    this.Announcements.SequenceEqual(input.Announcements)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.ResetDate != null)
                {
                    hashCode = (hashCode * 59) + this.ResetDate.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Stats != null)
                {
                    hashCode = (hashCode * 59) + this.Stats.GetHashCode();
                }
                if (this.Leaderboards != null)
                {
                    hashCode = (hashCode * 59) + this.Leaderboards.GetHashCode();
                }
                if (this.ServerResets != null)
                {
                    hashCode = (hashCode * 59) + this.ServerResets.GetHashCode();
                }
                if (this.Announcements != null)
                {
                    hashCode = (hashCode * 59) + this.Announcements.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
