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
    /// RegisterRequest
    /// </summary>
    [DataContract(Name = "register_request")]
    public partial class RegisterRequest : IEquatable<RegisterRequest>
    {
        /// <summary>
        /// The faction you choose determines your headquarters.
        /// </summary>
        /// <value>The faction you choose determines your headquarters.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FactionEnum
        {
            /// <summary>
            /// Enum COSMIC for value: COSMIC
            /// </summary>
            [EnumMember(Value = "COSMIC")]
            COSMIC = 1,

            /// <summary>
            /// Enum VOID for value: VOID
            /// </summary>
            [EnumMember(Value = "VOID")]
            VOID = 2,

            /// <summary>
            /// Enum GALACTIC for value: GALACTIC
            /// </summary>
            [EnumMember(Value = "GALACTIC")]
            GALACTIC = 3,

            /// <summary>
            /// Enum QUANTUM for value: QUANTUM
            /// </summary>
            [EnumMember(Value = "QUANTUM")]
            QUANTUM = 4,

            /// <summary>
            /// Enum DOMINION for value: DOMINION
            /// </summary>
            [EnumMember(Value = "DOMINION")]
            DOMINION = 5

        }


        /// <summary>
        /// The faction you choose determines your headquarters.
        /// </summary>
        /// <value>The faction you choose determines your headquarters.</value>
        [DataMember(Name = "faction", IsRequired = true, EmitDefaultValue = true)]
        public FactionEnum Faction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegisterRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterRequest" /> class.
        /// </summary>
        /// <param name="faction">The faction you choose determines your headquarters. (required).</param>
        /// <param name="symbol">How other agents will see your ships and information. (required).</param>
        /// <param name="email">Your email address. This is used if you reserved your call sign between resets..</param>
        public RegisterRequest(FactionEnum faction = default(FactionEnum), string symbol = default(string), string email = default(string))
        {
            this.Faction = faction;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for RegisterRequest and cannot be null");
            }
            this.Symbol = symbol;
            this.Email = email;
        }

        /// <summary>
        /// How other agents will see your ships and information.
        /// </summary>
        /// <value>How other agents will see your ships and information.</value>
        /// <example>&quot;BADGER&quot;</example>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Your email address. This is used if you reserved your call sign between resets.
        /// </summary>
        /// <value>Your email address. This is used if you reserved your call sign between resets.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegisterRequest {\n");
            sb.Append("  Faction: ").Append(Faction).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as RegisterRequest);
        }

        /// <summary>
        /// Returns true if RegisterRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Faction == input.Faction ||
                    this.Faction.Equals(input.Faction)
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                hashCode = (hashCode * 59) + this.Faction.GetHashCode();
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}