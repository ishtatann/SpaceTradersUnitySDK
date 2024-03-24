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
    /// The construction details of a waypoint.
    /// </summary>
    [DataContract(Name = "Construction")]
    public partial class Construction : IEquatable<Construction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Construction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Construction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Construction" /> class.
        /// </summary>
        /// <param name="symbol">The symbol of the waypoint. (required).</param>
        /// <param name="materials">The materials required to construct the waypoint. (required).</param>
        /// <param name="isComplete">Whether the waypoint has been constructed. (required).</param>
        public Construction(string symbol = default(string), List<ConstructionMaterial> materials = default(List<ConstructionMaterial>), bool isComplete = default(bool))
        {
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for Construction and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "materials" is required (not null)
            if (materials == null)
            {
                throw new ArgumentNullException("materials is a required property for Construction and cannot be null");
            }
            this.Materials = materials;
            this.IsComplete = isComplete;
        }

        /// <summary>
        /// The symbol of the waypoint.
        /// </summary>
        /// <value>The symbol of the waypoint.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// The materials required to construct the waypoint.
        /// </summary>
        /// <value>The materials required to construct the waypoint.</value>
        [DataMember(Name = "materials", IsRequired = true, EmitDefaultValue = true)]
        public List<ConstructionMaterial> Materials { get; set; }

        /// <summary>
        /// Whether the waypoint has been constructed.
        /// </summary>
        /// <value>Whether the waypoint has been constructed.</value>
        [DataMember(Name = "isComplete", IsRequired = true, EmitDefaultValue = true)]
        public bool IsComplete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Construction {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Materials: ").Append(Materials).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
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
            return this.Equals(input as Construction);
        }

        /// <summary>
        /// Returns true if Construction instances are equal
        /// </summary>
        /// <param name="input">Instance of Construction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Construction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Materials == input.Materials ||
                    this.Materials != null &&
                    input.Materials != null &&
                    this.Materials.SequenceEqual(input.Materials)
                ) && 
                (
                    this.IsComplete == input.IsComplete ||
                    this.IsComplete.Equals(input.IsComplete)
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
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.Materials != null)
                {
                    hashCode = (hashCode * 59) + this.Materials.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsComplete.GetHashCode();
                return hashCode;
            }
        }

    }

}
