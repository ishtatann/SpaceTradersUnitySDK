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
using System.Reflection;

namespace SpaceTradersUnitySDK.Model
{
    /// <summary>
    /// GetSystemWaypointsTraitsParameter
    /// </summary>
    [JsonConverter(typeof(GetSystemWaypointsTraitsParameterJsonConverter))]
    [DataContract(Name = "get_system_waypoints_traits_parameter")]
    public partial class GetSystemWaypointsTraitsParameter : AbstractOpenAPISchema, IEquatable<GetSystemWaypointsTraitsParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSystemWaypointsTraitsParameter" /> class
        /// with the <see cref="WaypointTraitSymbol" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WaypointTraitSymbol.</param>
        public GetSystemWaypointsTraitsParameter(WaypointTraitSymbol actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance; // ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSystemWaypointsTraitsParameter" /> class
        /// with the <see cref="List{WaypointTraitSymbol}" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of List&lt;WaypointTraitSymbol&gt;.</param>
        public GetSystemWaypointsTraitsParameter(List<WaypointTraitSymbol> actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(List<WaypointTraitSymbol>))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WaypointTraitSymbol))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: List<WaypointTraitSymbol>, WaypointTraitSymbol");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `WaypointTraitSymbol`. If the actual instance is not `WaypointTraitSymbol`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of WaypointTraitSymbol</returns>
        public WaypointTraitSymbol GetWaypointTraitSymbol()
        {
            return (WaypointTraitSymbol)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `List&lt;WaypointTraitSymbol&gt;`. If the actual instance is not `List&lt;WaypointTraitSymbol&gt;`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of List&lt;WaypointTraitSymbol&gt;</returns>
        public List<WaypointTraitSymbol> GetList()
        {
            return (List<WaypointTraitSymbol>)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSystemWaypointsTraitsParameter {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, GetSystemWaypointsTraitsParameter.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GetSystemWaypointsTraitsParameter
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GetSystemWaypointsTraitsParameter</returns>
        public static GetSystemWaypointsTraitsParameter FromJson(string jsonString)
        {
            GetSystemWaypointsTraitsParameter newGetSystemWaypointsTraitsParameter = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGetSystemWaypointsTraitsParameter;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(List<WaypointTraitSymbol>).GetProperty("AdditionalProperties") == null)
                {
                    newGetSystemWaypointsTraitsParameter = new GetSystemWaypointsTraitsParameter(JsonConvert.DeserializeObject<List<WaypointTraitSymbol>>(jsonString, GetSystemWaypointsTraitsParameter.SerializerSettings));
                }
                else
                {
                    newGetSystemWaypointsTraitsParameter = new GetSystemWaypointsTraitsParameter(JsonConvert.DeserializeObject<List<WaypointTraitSymbol>>(jsonString, GetSystemWaypointsTraitsParameter.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("List<WaypointTraitSymbol>");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                //System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<WaypointTraitSymbol>: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WaypointTraitSymbol).GetProperty("AdditionalProperties") == null)
                {
                    newGetSystemWaypointsTraitsParameter = new GetSystemWaypointsTraitsParameter(JsonConvert.DeserializeObject<WaypointTraitSymbol>(jsonString, GetSystemWaypointsTraitsParameter.SerializerSettings));
                }
                else
                {
                    newGetSystemWaypointsTraitsParameter = new GetSystemWaypointsTraitsParameter(JsonConvert.DeserializeObject<WaypointTraitSymbol>(jsonString, GetSystemWaypointsTraitsParameter.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WaypointTraitSymbol");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                //System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WaypointTraitSymbol: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newGetSystemWaypointsTraitsParameter;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetSystemWaypointsTraitsParameter);
        }

        /// <summary>
        /// Returns true if GetSystemWaypointsTraitsParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSystemWaypointsTraitsParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSystemWaypointsTraitsParameter input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

    }

    /// <summary>
    /// Custom JSON converter for GetSystemWaypointsTraitsParameter
    /// </summary>
    public class GetSystemWaypointsTraitsParameterJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GetSystemWaypointsTraitsParameter).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return GetSystemWaypointsTraitsParameter.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
