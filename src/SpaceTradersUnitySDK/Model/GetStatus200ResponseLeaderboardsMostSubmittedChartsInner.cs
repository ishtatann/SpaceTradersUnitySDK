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
    /// GetStatus200ResponseLeaderboardsMostSubmittedChartsInner
    /// </summary>
    [DataContract(Name = "get_status_200_response_leaderboards_mostSubmittedCharts_inner")]
    public partial class GetStatus200ResponseLeaderboardsMostSubmittedChartsInner : IEquatable<GetStatus200ResponseLeaderboardsMostSubmittedChartsInner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatus200ResponseLeaderboardsMostSubmittedChartsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetStatus200ResponseLeaderboardsMostSubmittedChartsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatus200ResponseLeaderboardsMostSubmittedChartsInner" /> class.
        /// </summary>
        /// <param name="agentSymbol">agentSymbol (required).</param>
        /// <param name="chartCount">chartCount (required).</param>
        public GetStatus200ResponseLeaderboardsMostSubmittedChartsInner(string agentSymbol = default(string), int chartCount = default(int))
        {
            // to ensure "agentSymbol" is required (not null)
            if (agentSymbol == null)
            {
                throw new ArgumentNullException("agentSymbol is a required property for GetStatus200ResponseLeaderboardsMostSubmittedChartsInner and cannot be null");
            }
            this.AgentSymbol = agentSymbol;
            this.ChartCount = chartCount;
        }

        /// <summary>
        /// Gets or Sets AgentSymbol
        /// </summary>
        [DataMember(Name = "agentSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string AgentSymbol { get; set; }

        /// <summary>
        /// Gets or Sets ChartCount
        /// </summary>
        [DataMember(Name = "chartCount", IsRequired = true, EmitDefaultValue = true)]
        public int ChartCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetStatus200ResponseLeaderboardsMostSubmittedChartsInner {\n");
            sb.Append("  AgentSymbol: ").Append(AgentSymbol).Append("\n");
            sb.Append("  ChartCount: ").Append(ChartCount).Append("\n");
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
            return this.Equals(input as GetStatus200ResponseLeaderboardsMostSubmittedChartsInner);
        }

        /// <summary>
        /// Returns true if GetStatus200ResponseLeaderboardsMostSubmittedChartsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStatus200ResponseLeaderboardsMostSubmittedChartsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStatus200ResponseLeaderboardsMostSubmittedChartsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgentSymbol == input.AgentSymbol ||
                    (this.AgentSymbol != null &&
                    this.AgentSymbol.Equals(input.AgentSymbol))
                ) && 
                (
                    this.ChartCount == input.ChartCount ||
                    this.ChartCount.Equals(input.ChartCount)
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
                if (this.AgentSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.AgentSymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChartCount.GetHashCode();
                return hashCode;
            }
        }

    }

}
