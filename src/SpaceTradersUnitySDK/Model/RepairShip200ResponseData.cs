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
    /// RepairShip200ResponseData
    /// </summary>
    [DataContract(Name = "repair_ship_200_response_data")]
    public partial class RepairShip200ResponseData : IEquatable<RepairShip200ResponseData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepairShip200ResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RepairShip200ResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepairShip200ResponseData" /> class.
        /// </summary>
        /// <param name="agent">agent (required).</param>
        /// <param name="ship">ship (required).</param>
        /// <param name="transaction">transaction (required).</param>
        public RepairShip200ResponseData(Agent agent = default(Agent), Ship ship = default(Ship), RepairTransaction transaction = default(RepairTransaction))
        {
            // to ensure "agent" is required (not null)
            if (agent == null)
            {
                throw new ArgumentNullException("agent is a required property for RepairShip200ResponseData and cannot be null");
            }
            this.Agent = agent;
            // to ensure "ship" is required (not null)
            if (ship == null)
            {
                throw new ArgumentNullException("ship is a required property for RepairShip200ResponseData and cannot be null");
            }
            this.Ship = ship;
            // to ensure "transaction" is required (not null)
            if (transaction == null)
            {
                throw new ArgumentNullException("transaction is a required property for RepairShip200ResponseData and cannot be null");
            }
            this.Transaction = transaction;
        }

        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name = "agent", IsRequired = true, EmitDefaultValue = true)]
        public Agent Agent { get; set; }

        /// <summary>
        /// Gets or Sets Ship
        /// </summary>
        [DataMember(Name = "ship", IsRequired = true, EmitDefaultValue = true)]
        public Ship Ship { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", IsRequired = true, EmitDefaultValue = true)]
        public RepairTransaction Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RepairShip200ResponseData {\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Ship: ").Append(Ship).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
            return this.Equals(input as RepairShip200ResponseData);
        }

        /// <summary>
        /// Returns true if RepairShip200ResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of RepairShip200ResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepairShip200ResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Agent == input.Agent ||
                    (this.Agent != null &&
                    this.Agent.Equals(input.Agent))
                ) && 
                (
                    this.Ship == input.Ship ||
                    (this.Ship != null &&
                    this.Ship.Equals(input.Ship))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
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
                if (this.Agent != null)
                {
                    hashCode = (hashCode * 59) + this.Agent.GetHashCode();
                }
                if (this.Ship != null)
                {
                    hashCode = (hashCode * 59) + this.Ship.GetHashCode();
                }
                if (this.Transaction != null)
                {
                    hashCode = (hashCode * 59) + this.Transaction.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
