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
    /// The supply level of a trade good.
    /// </summary>
    /// <value>The supply level of a trade good.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SupplyLevel
    {
        /// <summary>
        /// Enum SCARCE for value: SCARCE
        /// </summary>
        [EnumMember(Value = "SCARCE")]
        SCARCE = 1,

        /// <summary>
        /// Enum LIMITED for value: LIMITED
        /// </summary>
        [EnumMember(Value = "LIMITED")]
        LIMITED = 2,

        /// <summary>
        /// Enum MODERATE for value: MODERATE
        /// </summary>
        [EnumMember(Value = "MODERATE")]
        MODERATE = 3,

        /// <summary>
        /// Enum HIGH for value: HIGH
        /// </summary>
        [EnumMember(Value = "HIGH")]
        HIGH = 4,

        /// <summary>
        /// Enum ABUNDANT for value: ABUNDANT
        /// </summary>
        [EnumMember(Value = "ABUNDANT")]
        ABUNDANT = 5

    }

}
