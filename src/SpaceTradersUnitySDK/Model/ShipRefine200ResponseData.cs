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
    /// ShipRefine200ResponseData
    /// </summary>
    [DataContract(Name = "Ship_Refine_200_Response_data")]
    public partial class ShipRefine200ResponseData : IEquatable<ShipRefine200ResponseData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipRefine200ResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipRefine200ResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipRefine200ResponseData" /> class.
        /// </summary>
        /// <param name="cargo">cargo (required).</param>
        /// <param name="cooldown">cooldown (required).</param>
        /// <param name="produced">Goods that were produced by this refining process. (required).</param>
        /// <param name="consumed">Goods that were consumed during this refining process. (required).</param>
        public ShipRefine200ResponseData(ShipCargo cargo = default(ShipCargo), Cooldown cooldown = default(Cooldown), List<ShipRefine200ResponseDataProducedInner> produced = default(List<ShipRefine200ResponseDataProducedInner>), List<ShipRefine200ResponseDataProducedInner> consumed = default(List<ShipRefine200ResponseDataProducedInner>))
        {
            // to ensure "cargo" is required (not null)
            if (cargo == null)
            {
                throw new ArgumentNullException("cargo is a required property for ShipRefine200ResponseData and cannot be null");
            }
            this.Cargo = cargo;
            // to ensure "cooldown" is required (not null)
            if (cooldown == null)
            {
                throw new ArgumentNullException("cooldown is a required property for ShipRefine200ResponseData and cannot be null");
            }
            this.Cooldown = cooldown;
            // to ensure "produced" is required (not null)
            if (produced == null)
            {
                throw new ArgumentNullException("produced is a required property for ShipRefine200ResponseData and cannot be null");
            }
            this.Produced = produced;
            // to ensure "consumed" is required (not null)
            if (consumed == null)
            {
                throw new ArgumentNullException("consumed is a required property for ShipRefine200ResponseData and cannot be null");
            }
            this.Consumed = consumed;
        }

        /// <summary>
        /// Gets or Sets Cargo
        /// </summary>
        [DataMember(Name = "cargo", IsRequired = true, EmitDefaultValue = true)]
        public ShipCargo Cargo { get; set; }

        /// <summary>
        /// Gets or Sets Cooldown
        /// </summary>
        [DataMember(Name = "cooldown", IsRequired = true, EmitDefaultValue = true)]
        public Cooldown Cooldown { get; set; }

        /// <summary>
        /// Goods that were produced by this refining process.
        /// </summary>
        /// <value>Goods that were produced by this refining process.</value>
        [DataMember(Name = "produced", IsRequired = true, EmitDefaultValue = true)]
        public List<ShipRefine200ResponseDataProducedInner> Produced { get; set; }

        /// <summary>
        /// Goods that were consumed during this refining process.
        /// </summary>
        /// <value>Goods that were consumed during this refining process.</value>
        [DataMember(Name = "consumed", IsRequired = true, EmitDefaultValue = true)]
        public List<ShipRefine200ResponseDataProducedInner> Consumed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipRefine200ResponseData {\n");
            sb.Append("  Cargo: ").Append(Cargo).Append("\n");
            sb.Append("  Cooldown: ").Append(Cooldown).Append("\n");
            sb.Append("  Produced: ").Append(Produced).Append("\n");
            sb.Append("  Consumed: ").Append(Consumed).Append("\n");
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
            return this.Equals(input as ShipRefine200ResponseData);
        }

        /// <summary>
        /// Returns true if ShipRefine200ResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipRefine200ResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipRefine200ResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cargo == input.Cargo ||
                    (this.Cargo != null &&
                    this.Cargo.Equals(input.Cargo))
                ) && 
                (
                    this.Cooldown == input.Cooldown ||
                    (this.Cooldown != null &&
                    this.Cooldown.Equals(input.Cooldown))
                ) && 
                (
                    this.Produced == input.Produced ||
                    this.Produced != null &&
                    input.Produced != null &&
                    this.Produced.SequenceEqual(input.Produced)
                ) && 
                (
                    this.Consumed == input.Consumed ||
                    this.Consumed != null &&
                    input.Consumed != null &&
                    this.Consumed.SequenceEqual(input.Consumed)
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
                if (this.Cargo != null)
                {
                    hashCode = (hashCode * 59) + this.Cargo.GetHashCode();
                }
                if (this.Cooldown != null)
                {
                    hashCode = (hashCode * 59) + this.Cooldown.GetHashCode();
                }
                if (this.Produced != null)
                {
                    hashCode = (hashCode * 59) + this.Produced.GetHashCode();
                }
                if (this.Consumed != null)
                {
                    hashCode = (hashCode * 59) + this.Consumed.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
