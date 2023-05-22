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
    /// PatchShipNavRequest
    /// </summary>
    [DataContract(Name = "patch_ship_nav_request")]
    public partial class PatchShipNavRequest : IEquatable<PatchShipNavRequest>
    {

        /// <summary>
        /// Gets or Sets FlightMode
        /// </summary>
        [DataMember(Name = "flightMode", EmitDefaultValue = false)]
        public ShipNavFlightMode? FlightMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchShipNavRequest" /> class.
        /// </summary>
        /// <param name="flightMode">flightMode.</param>
        public PatchShipNavRequest(ShipNavFlightMode? flightMode = default(ShipNavFlightMode?))
        {
            this.FlightMode = flightMode;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchShipNavRequest {\n");
            sb.Append("  FlightMode: ").Append(FlightMode).Append("\n");
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
            return this.Equals(input as PatchShipNavRequest);
        }

        /// <summary>
        /// Returns true if PatchShipNavRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchShipNavRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchShipNavRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FlightMode == input.FlightMode ||
                    this.FlightMode.Equals(input.FlightMode)
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
                hashCode = (hashCode * 59) + this.FlightMode.GetHashCode();
                return hashCode;
            }
        }

    }

}