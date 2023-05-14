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
    /// ShipRefineRequest
    /// </summary>
    [DataContract(Name = "ship_refine_request")]
    public partial class ShipRefineRequest : IEquatable<ShipRefineRequest>
    {
        /// <summary>
        /// Defines Produce
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProduceEnum
        {
            /// <summary>
            /// Enum IRON for value: IRON
            /// </summary>
            [EnumMember(Value = "IRON")]
            IRON = 1,

            /// <summary>
            /// Enum COPPER for value: COPPER
            /// </summary>
            [EnumMember(Value = "COPPER")]
            COPPER = 2,

            /// <summary>
            /// Enum SILVER for value: SILVER
            /// </summary>
            [EnumMember(Value = "SILVER")]
            SILVER = 3,

            /// <summary>
            /// Enum GOLD for value: GOLD
            /// </summary>
            [EnumMember(Value = "GOLD")]
            GOLD = 4,

            /// <summary>
            /// Enum ALUMINUM for value: ALUMINUM
            /// </summary>
            [EnumMember(Value = "ALUMINUM")]
            ALUMINUM = 5,

            /// <summary>
            /// Enum PLATINUM for value: PLATINUM
            /// </summary>
            [EnumMember(Value = "PLATINUM")]
            PLATINUM = 6,

            /// <summary>
            /// Enum URANITE for value: URANITE
            /// </summary>
            [EnumMember(Value = "URANITE")]
            URANITE = 7,

            /// <summary>
            /// Enum MERITIUM for value: MERITIUM
            /// </summary>
            [EnumMember(Value = "MERITIUM")]
            MERITIUM = 8,

            /// <summary>
            /// Enum FUEL for value: FUEL
            /// </summary>
            [EnumMember(Value = "FUEL")]
            FUEL = 9

        }


        /// <summary>
        /// Gets or Sets Produce
        /// </summary>
        [DataMember(Name = "produce", IsRequired = true, EmitDefaultValue = true)]
        public ProduceEnum Produce { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipRefineRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipRefineRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipRefineRequest" /> class.
        /// </summary>
        /// <param name="produce">produce (required).</param>
        public ShipRefineRequest(ProduceEnum produce = default(ProduceEnum))
        {
            this.Produce = produce;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipRefineRequest {\n");
            sb.Append("  Produce: ").Append(Produce).Append("\n");
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
            return this.Equals(input as ShipRefineRequest);
        }

        /// <summary>
        /// Returns true if ShipRefineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipRefineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipRefineRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Produce == input.Produce ||
                    this.Produce.Equals(input.Produce)
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
                hashCode = (hashCode * 59) + this.Produce.GetHashCode();
                return hashCode;
            }
        }

    }

}
