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
    /// The unique identifier of the trait.
    /// </summary>
    /// <value>The unique identifier of the trait.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FactionTraitSymbol
    {
        /// <summary>
        /// Enum BUREAUCRATIC for value: BUREAUCRATIC
        /// </summary>
        [EnumMember(Value = "BUREAUCRATIC")]
        BUREAUCRATIC = 1,

        /// <summary>
        /// Enum SECRETIVE for value: SECRETIVE
        /// </summary>
        [EnumMember(Value = "SECRETIVE")]
        SECRETIVE = 2,

        /// <summary>
        /// Enum CAPITALISTIC for value: CAPITALISTIC
        /// </summary>
        [EnumMember(Value = "CAPITALISTIC")]
        CAPITALISTIC = 3,

        /// <summary>
        /// Enum INDUSTRIOUS for value: INDUSTRIOUS
        /// </summary>
        [EnumMember(Value = "INDUSTRIOUS")]
        INDUSTRIOUS = 4,

        /// <summary>
        /// Enum PEACEFUL for value: PEACEFUL
        /// </summary>
        [EnumMember(Value = "PEACEFUL")]
        PEACEFUL = 5,

        /// <summary>
        /// Enum DISTRUSTFUL for value: DISTRUSTFUL
        /// </summary>
        [EnumMember(Value = "DISTRUSTFUL")]
        DISTRUSTFUL = 6,

        /// <summary>
        /// Enum WELCOMING for value: WELCOMING
        /// </summary>
        [EnumMember(Value = "WELCOMING")]
        WELCOMING = 7,

        /// <summary>
        /// Enum SMUGGLERS for value: SMUGGLERS
        /// </summary>
        [EnumMember(Value = "SMUGGLERS")]
        SMUGGLERS = 8,

        /// <summary>
        /// Enum SCAVENGERS for value: SCAVENGERS
        /// </summary>
        [EnumMember(Value = "SCAVENGERS")]
        SCAVENGERS = 9,

        /// <summary>
        /// Enum REBELLIOUS for value: REBELLIOUS
        /// </summary>
        [EnumMember(Value = "REBELLIOUS")]
        REBELLIOUS = 10,

        /// <summary>
        /// Enum EXILES for value: EXILES
        /// </summary>
        [EnumMember(Value = "EXILES")]
        EXILES = 11,

        /// <summary>
        /// Enum PIRATES for value: PIRATES
        /// </summary>
        [EnumMember(Value = "PIRATES")]
        PIRATES = 12,

        /// <summary>
        /// Enum RAIDERS for value: RAIDERS
        /// </summary>
        [EnumMember(Value = "RAIDERS")]
        RAIDERS = 13,

        /// <summary>
        /// Enum CLAN for value: CLAN
        /// </summary>
        [EnumMember(Value = "CLAN")]
        CLAN = 14,

        /// <summary>
        /// Enum GUILD for value: GUILD
        /// </summary>
        [EnumMember(Value = "GUILD")]
        GUILD = 15,

        /// <summary>
        /// Enum DOMINION for value: DOMINION
        /// </summary>
        [EnumMember(Value = "DOMINION")]
        DOMINION = 16,

        /// <summary>
        /// Enum FRINGE for value: FRINGE
        /// </summary>
        [EnumMember(Value = "FRINGE")]
        FRINGE = 17,

        /// <summary>
        /// Enum FORSAKEN for value: FORSAKEN
        /// </summary>
        [EnumMember(Value = "FORSAKEN")]
        FORSAKEN = 18,

        /// <summary>
        /// Enum ISOLATED for value: ISOLATED
        /// </summary>
        [EnumMember(Value = "ISOLATED")]
        ISOLATED = 19,

        /// <summary>
        /// Enum LOCALIZED for value: LOCALIZED
        /// </summary>
        [EnumMember(Value = "LOCALIZED")]
        LOCALIZED = 20,

        /// <summary>
        /// Enum ESTABLISHED for value: ESTABLISHED
        /// </summary>
        [EnumMember(Value = "ESTABLISHED")]
        ESTABLISHED = 21,

        /// <summary>
        /// Enum NOTABLE for value: NOTABLE
        /// </summary>
        [EnumMember(Value = "NOTABLE")]
        NOTABLE = 22,

        /// <summary>
        /// Enum DOMINANT for value: DOMINANT
        /// </summary>
        [EnumMember(Value = "DOMINANT")]
        DOMINANT = 23,

        /// <summary>
        /// Enum INESCAPABLE for value: INESCAPABLE
        /// </summary>
        [EnumMember(Value = "INESCAPABLE")]
        INESCAPABLE = 24,

        /// <summary>
        /// Enum INNOVATIVE for value: INNOVATIVE
        /// </summary>
        [EnumMember(Value = "INNOVATIVE")]
        INNOVATIVE = 25,

        /// <summary>
        /// Enum BOLD for value: BOLD
        /// </summary>
        [EnumMember(Value = "BOLD")]
        BOLD = 26,

        /// <summary>
        /// Enum VISIONARY for value: VISIONARY
        /// </summary>
        [EnumMember(Value = "VISIONARY")]
        VISIONARY = 27,

        /// <summary>
        /// Enum CURIOUS for value: CURIOUS
        /// </summary>
        [EnumMember(Value = "CURIOUS")]
        CURIOUS = 28,

        /// <summary>
        /// Enum DARING for value: DARING
        /// </summary>
        [EnumMember(Value = "DARING")]
        DARING = 29,

        /// <summary>
        /// Enum EXPLORATORY for value: EXPLORATORY
        /// </summary>
        [EnumMember(Value = "EXPLORATORY")]
        EXPLORATORY = 30,

        /// <summary>
        /// Enum RESOURCEFUL for value: RESOURCEFUL
        /// </summary>
        [EnumMember(Value = "RESOURCEFUL")]
        RESOURCEFUL = 31,

        /// <summary>
        /// Enum FLEXIBLE for value: FLEXIBLE
        /// </summary>
        [EnumMember(Value = "FLEXIBLE")]
        FLEXIBLE = 32,

        /// <summary>
        /// Enum COOPERATIVE for value: COOPERATIVE
        /// </summary>
        [EnumMember(Value = "COOPERATIVE")]
        COOPERATIVE = 33,

        /// <summary>
        /// Enum UNITED for value: UNITED
        /// </summary>
        [EnumMember(Value = "UNITED")]
        UNITED = 34,

        /// <summary>
        /// Enum STRATEGIC for value: STRATEGIC
        /// </summary>
        [EnumMember(Value = "STRATEGIC")]
        STRATEGIC = 35,

        /// <summary>
        /// Enum INTELLIGENT for value: INTELLIGENT
        /// </summary>
        [EnumMember(Value = "INTELLIGENT")]
        INTELLIGENT = 36,

        /// <summary>
        /// Enum RESEARCHFOCUSED for value: RESEARCH_FOCUSED
        /// </summary>
        [EnumMember(Value = "RESEARCH_FOCUSED")]
        RESEARCHFOCUSED = 37,

        /// <summary>
        /// Enum COLLABORATIVE for value: COLLABORATIVE
        /// </summary>
        [EnumMember(Value = "COLLABORATIVE")]
        COLLABORATIVE = 38,

        /// <summary>
        /// Enum PROGRESSIVE for value: PROGRESSIVE
        /// </summary>
        [EnumMember(Value = "PROGRESSIVE")]
        PROGRESSIVE = 39,

        /// <summary>
        /// Enum MILITARISTIC for value: MILITARISTIC
        /// </summary>
        [EnumMember(Value = "MILITARISTIC")]
        MILITARISTIC = 40,

        /// <summary>
        /// Enum TECHNOLOGICALLYADVANCED for value: TECHNOLOGICALLY_ADVANCED
        /// </summary>
        [EnumMember(Value = "TECHNOLOGICALLY_ADVANCED")]
        TECHNOLOGICALLYADVANCED = 41,

        /// <summary>
        /// Enum AGGRESSIVE for value: AGGRESSIVE
        /// </summary>
        [EnumMember(Value = "AGGRESSIVE")]
        AGGRESSIVE = 42,

        /// <summary>
        /// Enum IMPERIALISTIC for value: IMPERIALISTIC
        /// </summary>
        [EnumMember(Value = "IMPERIALISTIC")]
        IMPERIALISTIC = 43,

        /// <summary>
        /// Enum TREASUREHUNTERS for value: TREASURE_HUNTERS
        /// </summary>
        [EnumMember(Value = "TREASURE_HUNTERS")]
        TREASUREHUNTERS = 44,

        /// <summary>
        /// Enum DEXTEROUS for value: DEXTEROUS
        /// </summary>
        [EnumMember(Value = "DEXTEROUS")]
        DEXTEROUS = 45,

        /// <summary>
        /// Enum UNPREDICTABLE for value: UNPREDICTABLE
        /// </summary>
        [EnumMember(Value = "UNPREDICTABLE")]
        UNPREDICTABLE = 46,

        /// <summary>
        /// Enum BRUTAL for value: BRUTAL
        /// </summary>
        [EnumMember(Value = "BRUTAL")]
        BRUTAL = 47,

        /// <summary>
        /// Enum FLEETING for value: FLEETING
        /// </summary>
        [EnumMember(Value = "FLEETING")]
        FLEETING = 48,

        /// <summary>
        /// Enum ADAPTABLE for value: ADAPTABLE
        /// </summary>
        [EnumMember(Value = "ADAPTABLE")]
        ADAPTABLE = 49,

        /// <summary>
        /// Enum SELFSUFFICIENT for value: SELF_SUFFICIENT
        /// </summary>
        [EnumMember(Value = "SELF_SUFFICIENT")]
        SELFSUFFICIENT = 50,

        /// <summary>
        /// Enum DEFENSIVE for value: DEFENSIVE
        /// </summary>
        [EnumMember(Value = "DEFENSIVE")]
        DEFENSIVE = 51,

        /// <summary>
        /// Enum PROUD for value: PROUD
        /// </summary>
        [EnumMember(Value = "PROUD")]
        PROUD = 52,

        /// <summary>
        /// Enum DIVERSE for value: DIVERSE
        /// </summary>
        [EnumMember(Value = "DIVERSE")]
        DIVERSE = 53,

        /// <summary>
        /// Enum INDEPENDENT for value: INDEPENDENT
        /// </summary>
        [EnumMember(Value = "INDEPENDENT")]
        INDEPENDENT = 54,

        /// <summary>
        /// Enum SELFINTERESTED for value: SELF_INTERESTED
        /// </summary>
        [EnumMember(Value = "SELF_INTERESTED")]
        SELFINTERESTED = 55,

        /// <summary>
        /// Enum FRAGMENTED for value: FRAGMENTED
        /// </summary>
        [EnumMember(Value = "FRAGMENTED")]
        FRAGMENTED = 56,

        /// <summary>
        /// Enum COMMERCIAL for value: COMMERCIAL
        /// </summary>
        [EnumMember(Value = "COMMERCIAL")]
        COMMERCIAL = 57,

        /// <summary>
        /// Enum FREEMARKETS for value: FREE_MARKETS
        /// </summary>
        [EnumMember(Value = "FREE_MARKETS")]
        FREEMARKETS = 58,

        /// <summary>
        /// Enum ENTREPRENEURIAL for value: ENTREPRENEURIAL
        /// </summary>
        [EnumMember(Value = "ENTREPRENEURIAL")]
        ENTREPRENEURIAL = 59

    }

}
