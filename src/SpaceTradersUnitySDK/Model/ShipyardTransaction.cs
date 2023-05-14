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
    /// ShipyardTransaction
    /// </summary>
    [DataContract(Name = "ShipyardTransaction")]
    public partial class ShipyardTransaction : IEquatable<ShipyardTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipyardTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipyardTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipyardTransaction" /> class.
        /// </summary>
        /// <param name="waypointSymbol">The symbol of the waypoint where the transaction took place. (required).</param>
        /// <param name="shipSymbol">The symbol of the ship that was purchased. (required).</param>
        /// <param name="price">The price of the transaction. (required).</param>
        /// <param name="agentSymbol">The symbol of the agent that made the transaction. (required).</param>
        /// <param name="timestamp">The timestamp of the transaction. (required).</param>
        public ShipyardTransaction(string waypointSymbol = default(string), string shipSymbol = default(string), int price = default(int), string agentSymbol = default(string), DateTime timestamp = default(DateTime))
        {
            // to ensure "waypointSymbol" is required (not null)
            if (waypointSymbol == null)
            {
                throw new ArgumentNullException("waypointSymbol is a required property for ShipyardTransaction and cannot be null");
            }
            this.WaypointSymbol = waypointSymbol;
            // to ensure "shipSymbol" is required (not null)
            if (shipSymbol == null)
            {
                throw new ArgumentNullException("shipSymbol is a required property for ShipyardTransaction and cannot be null");
            }
            this.ShipSymbol = shipSymbol;
            this.Price = price;
            // to ensure "agentSymbol" is required (not null)
            if (agentSymbol == null)
            {
                throw new ArgumentNullException("agentSymbol is a required property for ShipyardTransaction and cannot be null");
            }
            this.AgentSymbol = agentSymbol;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// The symbol of the waypoint where the transaction took place.
        /// </summary>
        /// <value>The symbol of the waypoint where the transaction took place.</value>
        [DataMember(Name = "waypointSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string WaypointSymbol { get; set; }

        /// <summary>
        /// The symbol of the ship that was purchased.
        /// </summary>
        /// <value>The symbol of the ship that was purchased.</value>
        [DataMember(Name = "shipSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string ShipSymbol { get; set; }

        /// <summary>
        /// The price of the transaction.
        /// </summary>
        /// <value>The price of the transaction.</value>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = true)]
        public int Price { get; set; }

        /// <summary>
        /// The symbol of the agent that made the transaction.
        /// </summary>
        /// <value>The symbol of the agent that made the transaction.</value>
        [DataMember(Name = "agentSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string AgentSymbol { get; set; }

        /// <summary>
        /// The timestamp of the transaction.
        /// </summary>
        /// <value>The timestamp of the transaction.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipyardTransaction {\n");
            sb.Append("  WaypointSymbol: ").Append(WaypointSymbol).Append("\n");
            sb.Append("  ShipSymbol: ").Append(ShipSymbol).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  AgentSymbol: ").Append(AgentSymbol).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as ShipyardTransaction);
        }

        /// <summary>
        /// Returns true if ShipyardTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipyardTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipyardTransaction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WaypointSymbol == input.WaypointSymbol ||
                    (this.WaypointSymbol != null &&
                    this.WaypointSymbol.Equals(input.WaypointSymbol))
                ) && 
                (
                    this.ShipSymbol == input.ShipSymbol ||
                    (this.ShipSymbol != null &&
                    this.ShipSymbol.Equals(input.ShipSymbol))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.AgentSymbol == input.AgentSymbol ||
                    (this.AgentSymbol != null &&
                    this.AgentSymbol.Equals(input.AgentSymbol))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.WaypointSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.WaypointSymbol.GetHashCode();
                }
                if (this.ShipSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.ShipSymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                if (this.AgentSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.AgentSymbol.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
