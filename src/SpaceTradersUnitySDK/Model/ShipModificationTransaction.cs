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
    /// Result of a transaction for a ship modification, such as installing a mount or a module.
    /// </summary>
    [DataContract(Name = "ShipModificationTransaction")]
    public partial class ShipModificationTransaction : IEquatable<ShipModificationTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipModificationTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipModificationTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipModificationTransaction" /> class.
        /// </summary>
        /// <param name="waypointSymbol">The symbol of the waypoint where the transaction took place. (required).</param>
        /// <param name="shipSymbol">The symbol of the ship that made the transaction. (required).</param>
        /// <param name="tradeSymbol">The symbol of the trade good. (required).</param>
        /// <param name="totalPrice">The total price of the transaction. (required).</param>
        /// <param name="timestamp">The timestamp of the transaction. (required).</param>
        public ShipModificationTransaction(string waypointSymbol = default(string), string shipSymbol = default(string), string tradeSymbol = default(string), int totalPrice = default(int), DateTime timestamp = default(DateTime))
        {
            // to ensure "waypointSymbol" is required (not null)
            if (waypointSymbol == null)
            {
                throw new ArgumentNullException("waypointSymbol is a required property for ShipModificationTransaction and cannot be null");
            }
            this.WaypointSymbol = waypointSymbol;
            // to ensure "shipSymbol" is required (not null)
            if (shipSymbol == null)
            {
                throw new ArgumentNullException("shipSymbol is a required property for ShipModificationTransaction and cannot be null");
            }
            this.ShipSymbol = shipSymbol;
            // to ensure "tradeSymbol" is required (not null)
            if (tradeSymbol == null)
            {
                throw new ArgumentNullException("tradeSymbol is a required property for ShipModificationTransaction and cannot be null");
            }
            this.TradeSymbol = tradeSymbol;
            this.TotalPrice = totalPrice;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// The symbol of the waypoint where the transaction took place.
        /// </summary>
        /// <value>The symbol of the waypoint where the transaction took place.</value>
        [DataMember(Name = "waypointSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string WaypointSymbol { get; set; }

        /// <summary>
        /// The symbol of the ship that made the transaction.
        /// </summary>
        /// <value>The symbol of the ship that made the transaction.</value>
        [DataMember(Name = "shipSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string ShipSymbol { get; set; }

        /// <summary>
        /// The symbol of the trade good.
        /// </summary>
        /// <value>The symbol of the trade good.</value>
        [DataMember(Name = "tradeSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string TradeSymbol { get; set; }

        /// <summary>
        /// The total price of the transaction.
        /// </summary>
        /// <value>The total price of the transaction.</value>
        [DataMember(Name = "totalPrice", IsRequired = true, EmitDefaultValue = true)]
        public int TotalPrice { get; set; }

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
            sb.Append("class ShipModificationTransaction {\n");
            sb.Append("  WaypointSymbol: ").Append(WaypointSymbol).Append("\n");
            sb.Append("  ShipSymbol: ").Append(ShipSymbol).Append("\n");
            sb.Append("  TradeSymbol: ").Append(TradeSymbol).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
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
            return this.Equals(input as ShipModificationTransaction);
        }

        /// <summary>
        /// Returns true if ShipModificationTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipModificationTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipModificationTransaction input)
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
                    this.TradeSymbol == input.TradeSymbol ||
                    (this.TradeSymbol != null &&
                    this.TradeSymbol.Equals(input.TradeSymbol))
                ) && 
                (
                    this.TotalPrice == input.TotalPrice ||
                    this.TotalPrice.Equals(input.TotalPrice)
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
                if (this.TradeSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.TradeSymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalPrice.GetHashCode();
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
