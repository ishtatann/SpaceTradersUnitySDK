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
    /// ConnectedSystem
    /// </summary>
    [DataContract(Name = "ConnectedSystem")]
    public partial class ConnectedSystem : IEquatable<ConnectedSystem>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public SystemType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedSystem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectedSystem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedSystem" /> class.
        /// </summary>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="sectorSymbol">sectorSymbol (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="factionSymbol">The symbol of the faction that owns the connected jump gate in the system..</param>
        /// <param name="x">x (required).</param>
        /// <param name="y">y (required).</param>
        /// <param name="distance">distance (required).</param>
        public ConnectedSystem(string symbol = default(string), string sectorSymbol = default(string), SystemType type = default(SystemType), string factionSymbol = default(string), int x = default(int), int y = default(int), int distance = default(int))
        {
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for ConnectedSystem and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "sectorSymbol" is required (not null)
            if (sectorSymbol == null)
            {
                throw new ArgumentNullException("sectorSymbol is a required property for ConnectedSystem and cannot be null");
            }
            this.SectorSymbol = sectorSymbol;
            this.Type = type;
            this.X = x;
            this.Y = y;
            this.Distance = distance;
            this.FactionSymbol = factionSymbol;
        }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets SectorSymbol
        /// </summary>
        [DataMember(Name = "sectorSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string SectorSymbol { get; set; }

        /// <summary>
        /// The symbol of the faction that owns the connected jump gate in the system.
        /// </summary>
        /// <value>The symbol of the faction that owns the connected jump gate in the system.</value>
        [DataMember(Name = "factionSymbol", EmitDefaultValue = false)]
        public string FactionSymbol { get; set; }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name = "x", IsRequired = true, EmitDefaultValue = true)]
        public int X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name = "y", IsRequired = true, EmitDefaultValue = true)]
        public int Y { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name = "distance", IsRequired = true, EmitDefaultValue = true)]
        public int Distance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectedSystem {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  SectorSymbol: ").Append(SectorSymbol).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FactionSymbol: ").Append(FactionSymbol).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
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
            return this.Equals(input as ConnectedSystem);
        }

        /// <summary>
        /// Returns true if ConnectedSystem instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectedSystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectedSystem input)
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
                    this.SectorSymbol == input.SectorSymbol ||
                    (this.SectorSymbol != null &&
                    this.SectorSymbol.Equals(input.SectorSymbol))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.FactionSymbol == input.FactionSymbol ||
                    (this.FactionSymbol != null &&
                    this.FactionSymbol.Equals(input.FactionSymbol))
                ) && 
                (
                    this.X == input.X ||
                    this.X.Equals(input.X)
                ) && 
                (
                    this.Y == input.Y ||
                    this.Y.Equals(input.Y)
                ) && 
                (
                    this.Distance == input.Distance ||
                    this.Distance.Equals(input.Distance)
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
                if (this.SectorSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.SectorSymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.FactionSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.FactionSymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.X.GetHashCode();
                hashCode = (hashCode * 59) + this.Y.GetHashCode();
                hashCode = (hashCode * 59) + this.Distance.GetHashCode();
                return hashCode;
            }
        }

    }

}
