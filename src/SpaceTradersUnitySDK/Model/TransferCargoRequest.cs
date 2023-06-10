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
    /// TransferCargoRequest
    /// </summary>
    [DataContract(Name = "Transfer_Cargo_Request")]
    public partial class TransferCargoRequest : IEquatable<TransferCargoRequest>
    {

        /// <summary>
        /// Gets or Sets TradeSymbol
        /// </summary>
        [DataMember(Name = "tradeSymbol", IsRequired = true, EmitDefaultValue = true)]
        public TradeSymbol TradeSymbol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCargoRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferCargoRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCargoRequest" /> class.
        /// </summary>
        /// <param name="tradeSymbol">tradeSymbol (required).</param>
        /// <param name="units">Amount of units to transfer. (required).</param>
        /// <param name="shipSymbol">The symbol of the ship to transfer to. (required).</param>
        public TransferCargoRequest(TradeSymbol tradeSymbol = default(TradeSymbol), int units = default(int), string shipSymbol = default(string))
        {
            this.TradeSymbol = tradeSymbol;
            this.Units = units;
            // to ensure "shipSymbol" is required (not null)
            if (shipSymbol == null)
            {
                throw new ArgumentNullException("shipSymbol is a required property for TransferCargoRequest and cannot be null");
            }
            this.ShipSymbol = shipSymbol;
        }

        /// <summary>
        /// Amount of units to transfer.
        /// </summary>
        /// <value>Amount of units to transfer.</value>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public int Units { get; set; }

        /// <summary>
        /// The symbol of the ship to transfer to.
        /// </summary>
        /// <value>The symbol of the ship to transfer to.</value>
        [DataMember(Name = "shipSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string ShipSymbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferCargoRequest {\n");
            sb.Append("  TradeSymbol: ").Append(TradeSymbol).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  ShipSymbol: ").Append(ShipSymbol).Append("\n");
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
            return this.Equals(input as TransferCargoRequest);
        }

        /// <summary>
        /// Returns true if TransferCargoRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferCargoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferCargoRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TradeSymbol == input.TradeSymbol ||
                    this.TradeSymbol.Equals(input.TradeSymbol)
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.ShipSymbol == input.ShipSymbol ||
                    (this.ShipSymbol != null &&
                    this.ShipSymbol.Equals(input.ShipSymbol))
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
                hashCode = (hashCode * 59) + this.TradeSymbol.GetHashCode();
                hashCode = (hashCode * 59) + this.Units.GetHashCode();
                if (this.ShipSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.ShipSymbol.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
