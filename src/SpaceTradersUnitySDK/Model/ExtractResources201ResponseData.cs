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
    /// ExtractResources201ResponseData
    /// </summary>
    [DataContract(Name = "extract_resources_201_response_data")]
    public partial class ExtractResources201ResponseData : IEquatable<ExtractResources201ResponseData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResources201ResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExtractResources201ResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResources201ResponseData" /> class.
        /// </summary>
        /// <param name="cooldown">cooldown (required).</param>
        /// <param name="extraction">extraction (required).</param>
        /// <param name="cargo">cargo (required).</param>
        /// <param name="events">events (required).</param>
        public ExtractResources201ResponseData(Cooldown cooldown = default(Cooldown), Extraction extraction = default(Extraction), ShipCargo cargo = default(ShipCargo), List<ExtractResources201ResponseDataEventsInner> events = default(List<ExtractResources201ResponseDataEventsInner>))
        {
            // to ensure "cooldown" is required (not null)
            if (cooldown == null)
            {
                throw new ArgumentNullException("cooldown is a required property for ExtractResources201ResponseData and cannot be null");
            }
            this.Cooldown = cooldown;
            // to ensure "extraction" is required (not null)
            if (extraction == null)
            {
                throw new ArgumentNullException("extraction is a required property for ExtractResources201ResponseData and cannot be null");
            }
            this.Extraction = extraction;
            // to ensure "cargo" is required (not null)
            if (cargo == null)
            {
                throw new ArgumentNullException("cargo is a required property for ExtractResources201ResponseData and cannot be null");
            }
            this.Cargo = cargo;
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new ArgumentNullException("events is a required property for ExtractResources201ResponseData and cannot be null");
            }
            this.Events = events;
        }

        /// <summary>
        /// Gets or Sets Cooldown
        /// </summary>
        [DataMember(Name = "cooldown", IsRequired = true, EmitDefaultValue = true)]
        public Cooldown Cooldown { get; set; }

        /// <summary>
        /// Gets or Sets Extraction
        /// </summary>
        [DataMember(Name = "extraction", IsRequired = true, EmitDefaultValue = true)]
        public Extraction Extraction { get; set; }

        /// <summary>
        /// Gets or Sets Cargo
        /// </summary>
        [DataMember(Name = "cargo", IsRequired = true, EmitDefaultValue = true)]
        public ShipCargo Cargo { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = true)]
        public List<ExtractResources201ResponseDataEventsInner> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExtractResources201ResponseData {\n");
            sb.Append("  Cooldown: ").Append(Cooldown).Append("\n");
            sb.Append("  Extraction: ").Append(Extraction).Append("\n");
            sb.Append("  Cargo: ").Append(Cargo).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
            return this.Equals(input as ExtractResources201ResponseData);
        }

        /// <summary>
        /// Returns true if ExtractResources201ResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtractResources201ResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtractResources201ResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cooldown == input.Cooldown ||
                    (this.Cooldown != null &&
                    this.Cooldown.Equals(input.Cooldown))
                ) && 
                (
                    this.Extraction == input.Extraction ||
                    (this.Extraction != null &&
                    this.Extraction.Equals(input.Extraction))
                ) && 
                (
                    this.Cargo == input.Cargo ||
                    (this.Cargo != null &&
                    this.Cargo.Equals(input.Cargo))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
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
                if (this.Cooldown != null)
                {
                    hashCode = (hashCode * 59) + this.Cooldown.GetHashCode();
                }
                if (this.Extraction != null)
                {
                    hashCode = (hashCode * 59) + this.Extraction.GetHashCode();
                }
                if (this.Cargo != null)
                {
                    hashCode = (hashCode * 59) + this.Cargo.GetHashCode();
                }
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
