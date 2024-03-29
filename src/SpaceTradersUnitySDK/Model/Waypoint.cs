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
    /// A waypoint is a location that ships can travel to such as a Planet, Moon or Space Station.
    /// </summary>
    [DataContract(Name = "Waypoint")]
    public partial class Waypoint : IEquatable<Waypoint>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public WaypointType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Waypoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Waypoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Waypoint" /> class.
        /// </summary>
        /// <param name="symbol">The symbol of the waypoint. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="systemSymbol">The symbol of the system. (required).</param>
        /// <param name="x">Relative position of the waypoint on the system&#39;s x axis. This is not an absolute position in the universe. (required).</param>
        /// <param name="y">Relative position of the waypoint on the system&#39;s y axis. This is not an absolute position in the universe. (required).</param>
        /// <param name="orbitals">Waypoints that orbit this waypoint. (required).</param>
        /// <param name="orbits">The symbol of the parent waypoint, if this waypoint is in orbit around another waypoint. Otherwise this value is undefined..</param>
        /// <param name="faction">faction.</param>
        /// <param name="traits">The traits of the waypoint. (required).</param>
        /// <param name="modifiers">The modifiers of the waypoint..</param>
        /// <param name="chart">chart.</param>
        /// <param name="isUnderConstruction">True if the waypoint is under construction. (required).</param>
        public Waypoint(string symbol = default(string), WaypointType type = default(WaypointType), string systemSymbol = default(string), int x = default(int), int y = default(int), List<WaypointOrbital> orbitals = default(List<WaypointOrbital>), string orbits = default(string), WaypointFaction faction = default(WaypointFaction), List<WaypointTrait> traits = default(List<WaypointTrait>), List<WaypointModifier> modifiers = default(List<WaypointModifier>), Chart chart = default(Chart), bool isUnderConstruction = default(bool))
        {
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for Waypoint and cannot be null");
            }
            this.Symbol = symbol;
            this.Type = type;
            // to ensure "systemSymbol" is required (not null)
            if (systemSymbol == null)
            {
                throw new ArgumentNullException("systemSymbol is a required property for Waypoint and cannot be null");
            }
            this.SystemSymbol = systemSymbol;
            this.X = x;
            this.Y = y;
            // to ensure "orbitals" is required (not null)
            if (orbitals == null)
            {
                throw new ArgumentNullException("orbitals is a required property for Waypoint and cannot be null");
            }
            this.Orbitals = orbitals;
            // to ensure "traits" is required (not null)
            if (traits == null)
            {
                throw new ArgumentNullException("traits is a required property for Waypoint and cannot be null");
            }
            this.Traits = traits;
            this.IsUnderConstruction = isUnderConstruction;
            this.Orbits = orbits;
            this.Faction = faction;
            this.Modifiers = modifiers;
            this.Chart = chart;
        }

        /// <summary>
        /// The symbol of the waypoint.
        /// </summary>
        /// <value>The symbol of the waypoint.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// The symbol of the system.
        /// </summary>
        /// <value>The symbol of the system.</value>
        [DataMember(Name = "systemSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string SystemSymbol { get; set; }

        /// <summary>
        /// Relative position of the waypoint on the system&#39;s x axis. This is not an absolute position in the universe.
        /// </summary>
        /// <value>Relative position of the waypoint on the system&#39;s x axis. This is not an absolute position in the universe.</value>
        [DataMember(Name = "x", IsRequired = true, EmitDefaultValue = true)]
        public int X { get; set; }

        /// <summary>
        /// Relative position of the waypoint on the system&#39;s y axis. This is not an absolute position in the universe.
        /// </summary>
        /// <value>Relative position of the waypoint on the system&#39;s y axis. This is not an absolute position in the universe.</value>
        [DataMember(Name = "y", IsRequired = true, EmitDefaultValue = true)]
        public int Y { get; set; }

        /// <summary>
        /// Waypoints that orbit this waypoint.
        /// </summary>
        /// <value>Waypoints that orbit this waypoint.</value>
        [DataMember(Name = "orbitals", IsRequired = true, EmitDefaultValue = true)]
        public List<WaypointOrbital> Orbitals { get; set; }

        /// <summary>
        /// The symbol of the parent waypoint, if this waypoint is in orbit around another waypoint. Otherwise this value is undefined.
        /// </summary>
        /// <value>The symbol of the parent waypoint, if this waypoint is in orbit around another waypoint. Otherwise this value is undefined.</value>
        [DataMember(Name = "orbits", EmitDefaultValue = false)]
        public string Orbits { get; set; }

        /// <summary>
        /// Gets or Sets Faction
        /// </summary>
        [DataMember(Name = "faction", EmitDefaultValue = false)]
        public WaypointFaction Faction { get; set; }

        /// <summary>
        /// The traits of the waypoint.
        /// </summary>
        /// <value>The traits of the waypoint.</value>
        [DataMember(Name = "traits", IsRequired = true, EmitDefaultValue = true)]
        public List<WaypointTrait> Traits { get; set; }

        /// <summary>
        /// The modifiers of the waypoint.
        /// </summary>
        /// <value>The modifiers of the waypoint.</value>
        [DataMember(Name = "modifiers", EmitDefaultValue = false)]
        public List<WaypointModifier> Modifiers { get; set; }

        /// <summary>
        /// Gets or Sets Chart
        /// </summary>
        [DataMember(Name = "chart", EmitDefaultValue = false)]
        public Chart Chart { get; set; }

        /// <summary>
        /// True if the waypoint is under construction.
        /// </summary>
        /// <value>True if the waypoint is under construction.</value>
        [DataMember(Name = "isUnderConstruction", IsRequired = true, EmitDefaultValue = true)]
        public bool IsUnderConstruction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Waypoint {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SystemSymbol: ").Append(SystemSymbol).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Orbitals: ").Append(Orbitals).Append("\n");
            sb.Append("  Orbits: ").Append(Orbits).Append("\n");
            sb.Append("  Faction: ").Append(Faction).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
            sb.Append("  Chart: ").Append(Chart).Append("\n");
            sb.Append("  IsUnderConstruction: ").Append(IsUnderConstruction).Append("\n");
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
            return this.Equals(input as Waypoint);
        }

        /// <summary>
        /// Returns true if Waypoint instances are equal
        /// </summary>
        /// <param name="input">Instance of Waypoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Waypoint input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SystemSymbol == input.SystemSymbol ||
                    (this.SystemSymbol != null &&
                    this.SystemSymbol.Equals(input.SystemSymbol))
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
                    this.Orbitals == input.Orbitals ||
                    this.Orbitals != null &&
                    input.Orbitals != null &&
                    this.Orbitals.SequenceEqual(input.Orbitals)
                ) && 
                (
                    this.Orbits == input.Orbits ||
                    (this.Orbits != null &&
                    this.Orbits.Equals(input.Orbits))
                ) && 
                (
                    this.Faction == input.Faction ||
                    (this.Faction != null &&
                    this.Faction.Equals(input.Faction))
                ) && 
                (
                    this.Traits == input.Traits ||
                    this.Traits != null &&
                    input.Traits != null &&
                    this.Traits.SequenceEqual(input.Traits)
                ) && 
                (
                    this.Modifiers == input.Modifiers ||
                    this.Modifiers != null &&
                    input.Modifiers != null &&
                    this.Modifiers.SequenceEqual(input.Modifiers)
                ) && 
                (
                    this.Chart == input.Chart ||
                    (this.Chart != null &&
                    this.Chart.Equals(input.Chart))
                ) && 
                (
                    this.IsUnderConstruction == input.IsUnderConstruction ||
                    this.IsUnderConstruction.Equals(input.IsUnderConstruction)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.SystemSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.SystemSymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.X.GetHashCode();
                hashCode = (hashCode * 59) + this.Y.GetHashCode();
                if (this.Orbitals != null)
                {
                    hashCode = (hashCode * 59) + this.Orbitals.GetHashCode();
                }
                if (this.Orbits != null)
                {
                    hashCode = (hashCode * 59) + this.Orbits.GetHashCode();
                }
                if (this.Faction != null)
                {
                    hashCode = (hashCode * 59) + this.Faction.GetHashCode();
                }
                if (this.Traits != null)
                {
                    hashCode = (hashCode * 59) + this.Traits.GetHashCode();
                }
                if (this.Modifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Modifiers.GetHashCode();
                }
                if (this.Chart != null)
                {
                    hashCode = (hashCode * 59) + this.Chart.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsUnderConstruction.GetHashCode();
                return hashCode;
            }
        }

    }

}
