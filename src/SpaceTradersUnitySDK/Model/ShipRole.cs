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
    /// The registered role of the ship
    /// </summary>
    /// <value>The registered role of the ship</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShipRole
    {
        /// <summary>
        /// Enum FABRICATOR for value: FABRICATOR
        /// </summary>
        [EnumMember(Value = "FABRICATOR")]
        FABRICATOR = 1,

        /// <summary>
        /// Enum HARVESTER for value: HARVESTER
        /// </summary>
        [EnumMember(Value = "HARVESTER")]
        HARVESTER = 2,

        /// <summary>
        /// Enum HAULER for value: HAULER
        /// </summary>
        [EnumMember(Value = "HAULER")]
        HAULER = 3,

        /// <summary>
        /// Enum INTERCEPTOR for value: INTERCEPTOR
        /// </summary>
        [EnumMember(Value = "INTERCEPTOR")]
        INTERCEPTOR = 4,

        /// <summary>
        /// Enum EXCAVATOR for value: EXCAVATOR
        /// </summary>
        [EnumMember(Value = "EXCAVATOR")]
        EXCAVATOR = 5,

        /// <summary>
        /// Enum TRANSPORT for value: TRANSPORT
        /// </summary>
        [EnumMember(Value = "TRANSPORT")]
        TRANSPORT = 6,

        /// <summary>
        /// Enum REPAIR for value: REPAIR
        /// </summary>
        [EnumMember(Value = "REPAIR")]
        REPAIR = 7,

        /// <summary>
        /// Enum SURVEYOR for value: SURVEYOR
        /// </summary>
        [EnumMember(Value = "SURVEYOR")]
        SURVEYOR = 8,

        /// <summary>
        /// Enum COMMAND for value: COMMAND
        /// </summary>
        [EnumMember(Value = "COMMAND")]
        COMMAND = 9,

        /// <summary>
        /// Enum CARRIER for value: CARRIER
        /// </summary>
        [EnumMember(Value = "CARRIER")]
        CARRIER = 10,

        /// <summary>
        /// Enum PATROL for value: PATROL
        /// </summary>
        [EnumMember(Value = "PATROL")]
        PATROL = 11,

        /// <summary>
        /// Enum SATELLITE for value: SATELLITE
        /// </summary>
        [EnumMember(Value = "SATELLITE")]
        SATELLITE = 12,

        /// <summary>
        /// Enum EXPLORER for value: EXPLORER
        /// </summary>
        [EnumMember(Value = "EXPLORER")]
        EXPLORER = 13,

        /// <summary>
        /// Enum REFINERY for value: REFINERY
        /// </summary>
        [EnumMember(Value = "REFINERY")]
        REFINERY = 14

    }

}
