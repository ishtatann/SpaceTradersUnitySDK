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
    /// The terms to fulfill the contract.
    /// </summary>
    [DataContract(Name = "ContractTerms")]
    public partial class ContractTerms : IEquatable<ContractTerms>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractTerms" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContractTerms() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractTerms" /> class.
        /// </summary>
        /// <param name="deadline">The deadline for the contract. (required).</param>
        /// <param name="payment">payment (required).</param>
        /// <param name="deliver">The cargo that needs to be delivered to fulfill the contract..</param>
        public ContractTerms(DateTime deadline = default(DateTime), ContractPayment payment = default(ContractPayment), List<ContractDeliverGood> deliver = default(List<ContractDeliverGood>))
        {
            this.Deadline = deadline;
            // to ensure "payment" is required (not null)
            if (payment == null)
            {
                throw new ArgumentNullException("payment is a required property for ContractTerms and cannot be null");
            }
            this.Payment = payment;
            this.Deliver = deliver;
        }

        /// <summary>
        /// The deadline for the contract.
        /// </summary>
        /// <value>The deadline for the contract.</value>
        [DataMember(Name = "deadline", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Deadline { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name = "payment", IsRequired = true, EmitDefaultValue = true)]
        public ContractPayment Payment { get; set; }

        /// <summary>
        /// The cargo that needs to be delivered to fulfill the contract.
        /// </summary>
        /// <value>The cargo that needs to be delivered to fulfill the contract.</value>
        [DataMember(Name = "deliver", EmitDefaultValue = false)]
        public List<ContractDeliverGood> Deliver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContractTerms {\n");
            sb.Append("  Deadline: ").Append(Deadline).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Deliver: ").Append(Deliver).Append("\n");
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
            return this.Equals(input as ContractTerms);
        }

        /// <summary>
        /// Returns true if ContractTerms instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractTerms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractTerms input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Deadline == input.Deadline ||
                    (this.Deadline != null &&
                    this.Deadline.Equals(input.Deadline))
                ) && 
                (
                    this.Payment == input.Payment ||
                    (this.Payment != null &&
                    this.Payment.Equals(input.Payment))
                ) && 
                (
                    this.Deliver == input.Deliver ||
                    this.Deliver != null &&
                    input.Deliver != null &&
                    this.Deliver.SequenceEqual(input.Deliver)
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
                if (this.Deadline != null)
                {
                    hashCode = (hashCode * 59) + this.Deadline.GetHashCode();
                }
                if (this.Payment != null)
                {
                    hashCode = (hashCode * 59) + this.Payment.GetHashCode();
                }
                if (this.Deliver != null)
                {
                    hashCode = (hashCode * 59) + this.Deliver.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
