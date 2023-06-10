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
    /// System
    /// </summary>
    [DataContract(Name = "System")]
    public partial class System : IEquatable<System>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public SystemType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="System" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected System() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="System" /> class.
        /// </summary>
        /// <param name="symbol">The symbol of the system. (required).</param>
        /// <param name="sectorSymbol">The symbol of the sector. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="x">Position in the universe in the x axis. (required).</param>
        /// <param name="y">Position in the universe in the y axis. (required).</param>
        /// <param name="waypoints">Waypoints in this system. (required).</param>
        /// <param name="factions">Factions that control this system. (required).</param>
        public System(string symbol = default(string), string sectorSymbol = default(string), SystemType type = default(SystemType), int x = default(int), int y = default(int), List<SystemWaypoint> waypoints = default(List<SystemWaypoint>), List<SystemFaction> factions = default(List<SystemFaction>))
        {
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for System and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "sectorSymbol" is required (not null)
            if (sectorSymbol == null)
            {
                throw new ArgumentNullException("sectorSymbol is a required property for System and cannot be null");
            }
            this.SectorSymbol = sectorSymbol;
            this.Type = type;
            this.X = x;
            this.Y = y;
            // to ensure "waypoints" is required (not null)
            if (waypoints == null)
            {
                throw new ArgumentNullException("waypoints is a required property for System and cannot be null");
            }
            this.Waypoints = waypoints;
            // to ensure "factions" is required (not null)
            if (factions == null)
            {
                throw new ArgumentNullException("factions is a required property for System and cannot be null");
            }
            this.Factions = factions;
        }

        /// <summary>
        /// The symbol of the system.
        /// </summary>
        /// <value>The symbol of the system.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// The symbol of the sector.
        /// </summary>
        /// <value>The symbol of the sector.</value>
        [DataMember(Name = "sectorSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string SectorSymbol { get; set; }

        /// <summary>
        /// Position in the universe in the x axis.
        /// </summary>
        /// <value>Position in the universe in the x axis.</value>
        [DataMember(Name = "x", IsRequired = true, EmitDefaultValue = true)]
        public int X { get; set; }

        /// <summary>
        /// Position in the universe in the y axis.
        /// </summary>
        /// <value>Position in the universe in the y axis.</value>
        [DataMember(Name = "y", IsRequired = true, EmitDefaultValue = true)]
        public int Y { get; set; }

        /// <summary>
        /// Waypoints in this system.
        /// </summary>
        /// <value>Waypoints in this system.</value>
        [DataMember(Name = "waypoints", IsRequired = true, EmitDefaultValue = true)]
        public List<SystemWaypoint> Waypoints { get; set; }

        /// <summary>
        /// Factions that control this system.
        /// </summary>
        /// <value>Factions that control this system.</value>
        [DataMember(Name = "factions", IsRequired = true, EmitDefaultValue = true)]
        public List<SystemFaction> Factions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class System {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  SectorSymbol: ").Append(SectorSymbol).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Waypoints: ").Append(Waypoints).Append("\n");
            sb.Append("  Factions: ").Append(Factions).Append("\n");
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
            return this.Equals(input as System);
        }

        /// <summary>
        /// Returns true if System instances are equal
        /// </summary>
        /// <param name="input">Instance of System to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(System input)
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
                    this.X == input.X ||
                    this.X.Equals(input.X)
                ) && 
                (
                    this.Y == input.Y ||
                    this.Y.Equals(input.Y)
                ) && 
                (
                    this.Waypoints == input.Waypoints ||
                    this.Waypoints != null &&
                    input.Waypoints != null &&
                    this.Waypoints.SequenceEqual(input.Waypoints)
                ) && 
                (
                    this.Factions == input.Factions ||
                    this.Factions != null &&
                    input.Factions != null &&
                    this.Factions.SequenceEqual(input.Factions)
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
                hashCode = (hashCode * 59) + this.X.GetHashCode();
                hashCode = (hashCode * 59) + this.Y.GetHashCode();
                if (this.Waypoints != null)
                {
                    hashCode = (hashCode * 59) + this.Waypoints.GetHashCode();
                }
                if (this.Factions != null)
                {
                    hashCode = (hashCode * 59) + this.Factions.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
