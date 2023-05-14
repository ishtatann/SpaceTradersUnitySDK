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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace SpaceTradersUnitySDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Register New Agent
        /// </summary>
        /// <remarks>
        /// Creates a new agent and ties it to a temporary Account.  The agent symbol is a 3-14 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.  A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.  &gt; #### Keep your token safe and secure &gt; &gt; Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.  You can accept your contract using the &#x60;/my/contracts/{contractId}/accept&#x60; endpoint. You will want to navigate your command ship to a nearby asteroid field and execute the &#x60;/my/ships/{shipSymbol}/extract&#x60; endpoint to mine various types of ores and minerals.  Return to the contract destination and execute the &#x60;/my/ships/{shipSymbol}/deliver&#x60; endpoint to deposit goods into the contract.  When your contract is fulfilled, you can call &#x60;/my/contracts/{contractId}/fulfill&#x60; to retrieve payment.
        /// </remarks>
        /// <exception cref="SpaceTradersUnitySDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registerRequest"> (optional)</param>
        /// <returns>Register201Response</returns>
        Register201Response Register(RegisterRequest registerRequest = default(RegisterRequest));

        /// <summary>
        /// Register New Agent
        /// </summary>
        /// <remarks>
        /// Creates a new agent and ties it to a temporary Account.  The agent symbol is a 3-14 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.  A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.  &gt; #### Keep your token safe and secure &gt; &gt; Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.  You can accept your contract using the &#x60;/my/contracts/{contractId}/accept&#x60; endpoint. You will want to navigate your command ship to a nearby asteroid field and execute the &#x60;/my/ships/{shipSymbol}/extract&#x60; endpoint to mine various types of ores and minerals.  Return to the contract destination and execute the &#x60;/my/ships/{shipSymbol}/deliver&#x60; endpoint to deposit goods into the contract.  When your contract is fulfilled, you can call &#x60;/my/contracts/{contractId}/fulfill&#x60; to retrieve payment.
        /// </remarks>
        /// <exception cref="SpaceTradersUnitySDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registerRequest"> (optional)</param>
        /// <returns>ApiResponse of Register201Response</returns>
        ApiResponse<Register201Response> RegisterWithHttpInfo(RegisterRequest registerRequest = default(RegisterRequest));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Register New Agent
        /// </summary>
        /// <remarks>
        /// Creates a new agent and ties it to a temporary Account.  The agent symbol is a 3-14 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.  A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.  &gt; #### Keep your token safe and secure &gt; &gt; Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.  You can accept your contract using the &#x60;/my/contracts/{contractId}/accept&#x60; endpoint. You will want to navigate your command ship to a nearby asteroid field and execute the &#x60;/my/ships/{shipSymbol}/extract&#x60; endpoint to mine various types of ores and minerals.  Return to the contract destination and execute the &#x60;/my/ships/{shipSymbol}/deliver&#x60; endpoint to deposit goods into the contract.  When your contract is fulfilled, you can call &#x60;/my/contracts/{contractId}/fulfill&#x60; to retrieve payment.
        /// </remarks>
        /// <exception cref="SpaceTradersUnitySDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Register201Response</returns>
        System.Threading.Tasks.Task<Register201Response> RegisterAsync(RegisterRequest registerRequest = default(RegisterRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Register New Agent
        /// </summary>
        /// <remarks>
        /// Creates a new agent and ties it to a temporary Account.  The agent symbol is a 3-14 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.  A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.  &gt; #### Keep your token safe and secure &gt; &gt; Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.  You can accept your contract using the &#x60;/my/contracts/{contractId}/accept&#x60; endpoint. You will want to navigate your command ship to a nearby asteroid field and execute the &#x60;/my/ships/{shipSymbol}/extract&#x60; endpoint to mine various types of ores and minerals.  Return to the contract destination and execute the &#x60;/my/ships/{shipSymbol}/deliver&#x60; endpoint to deposit goods into the contract.  When your contract is fulfilled, you can call &#x60;/my/contracts/{contractId}/fulfill&#x60; to retrieve payment.
        /// </remarks>
        /// <exception cref="SpaceTradersUnitySDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Register201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Register201Response>> RegisterWithHttpInfoAsync(RegisterRequest registerRequest = default(RegisterRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi : IDefaultApiSync, IDefaultApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DefaultApi : IDisposable, IDefaultApi
    {
        private SpaceTradersUnitySDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public DefaultApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public DefaultApi(string basePath)
        {
            this.Configuration = SpaceTradersUnitySDK.Client.Configuration.MergeConfigurations(
                SpaceTradersUnitySDK.Client.GlobalConfiguration.Instance,
                new SpaceTradersUnitySDK.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new SpaceTradersUnitySDK.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = SpaceTradersUnitySDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public DefaultApi(SpaceTradersUnitySDK.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = SpaceTradersUnitySDK.Client.Configuration.MergeConfigurations(
                SpaceTradersUnitySDK.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new SpaceTradersUnitySDK.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = SpaceTradersUnitySDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public DefaultApi(SpaceTradersUnitySDK.Client.ISynchronousClient client, SpaceTradersUnitySDK.Client.IAsynchronousClient asyncClient, SpaceTradersUnitySDK.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = SpaceTradersUnitySDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public SpaceTradersUnitySDK.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public SpaceTradersUnitySDK.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public SpaceTradersUnitySDK.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SpaceTradersUnitySDK.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SpaceTradersUnitySDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Register New Agent Creates a new agent and ties it to a temporary Account.  The agent symbol is a 3-14 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.  A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.  &gt; #### Keep your token safe and secure &gt; &gt; Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.  You can accept your contract using the &#x60;/my/contracts/{contractId}/accept&#x60; endpoint. You will want to navigate your command ship to a nearby asteroid field and execute the &#x60;/my/ships/{shipSymbol}/extract&#x60; endpoint to mine various types of ores and minerals.  Return to the contract destination and execute the &#x60;/my/ships/{shipSymbol}/deliver&#x60; endpoint to deposit goods into the contract.  When your contract is fulfilled, you can call &#x60;/my/contracts/{contractId}/fulfill&#x60; to retrieve payment.
        /// </summary>
        /// <exception cref="SpaceTradersUnitySDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registerRequest"> (optional)</param>
        /// <returns>Register201Response</returns>
        public Register201Response Register(RegisterRequest registerRequest = default(RegisterRequest))
        {
            SpaceTradersUnitySDK.Client.ApiResponse<Register201Response> localVarResponse = RegisterWithHttpInfo(registerRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Register New Agent Creates a new agent and ties it to a temporary Account.  The agent symbol is a 3-14 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.  A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.  &gt; #### Keep your token safe and secure &gt; &gt; Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.  You can accept your contract using the &#x60;/my/contracts/{contractId}/accept&#x60; endpoint. You will want to navigate your command ship to a nearby asteroid field and execute the &#x60;/my/ships/{shipSymbol}/extract&#x60; endpoint to mine various types of ores and minerals.  Return to the contract destination and execute the &#x60;/my/ships/{shipSymbol}/deliver&#x60; endpoint to deposit goods into the contract.  When your contract is fulfilled, you can call &#x60;/my/contracts/{contractId}/fulfill&#x60; to retrieve payment.
        /// </summary>
        /// <exception cref="SpaceTradersUnitySDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registerRequest"> (optional)</param>
        /// <returns>ApiResponse of Register201Response</returns>
        public SpaceTradersUnitySDK.Client.ApiResponse<Register201Response> RegisterWithHttpInfo(RegisterRequest registerRequest = default(RegisterRequest))
        {
            SpaceTradersUnitySDK.Client.RequestOptions localVarRequestOptions = new SpaceTradersUnitySDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = SpaceTradersUnitySDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SpaceTradersUnitySDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = registerRequest;

            // authentication (AgentToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Register201Response>("/register", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Register", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Register New Agent Creates a new agent and ties it to a temporary Account.  The agent symbol is a 3-14 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.  A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.  &gt; #### Keep your token safe and secure &gt; &gt; Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.  You can accept your contract using the &#x60;/my/contracts/{contractId}/accept&#x60; endpoint. You will want to navigate your command ship to a nearby asteroid field and execute the &#x60;/my/ships/{shipSymbol}/extract&#x60; endpoint to mine various types of ores and minerals.  Return to the contract destination and execute the &#x60;/my/ships/{shipSymbol}/deliver&#x60; endpoint to deposit goods into the contract.  When your contract is fulfilled, you can call &#x60;/my/contracts/{contractId}/fulfill&#x60; to retrieve payment.
        /// </summary>
        /// <exception cref="SpaceTradersUnitySDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Register201Response</returns>
        public async System.Threading.Tasks.Task<Register201Response> RegisterAsync(RegisterRequest registerRequest = default(RegisterRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var task = RegisterWithHttpInfoAsync(registerRequest, cancellationToken);
#if UNITY_EDITOR || !UNITY_WEBGL
            SpaceTradersUnitySDK.Client.ApiResponse<Register201Response> localVarResponse = await task.ConfigureAwait(false);
#else
            SpaceTradersUnitySDK.Client.ApiResponse<Register201Response> localVarResponse = await task;
#endif
            return localVarResponse.Data;
        }

        /// <summary>
        /// Register New Agent Creates a new agent and ties it to a temporary Account.  The agent symbol is a 3-14 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.  A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.  &gt; #### Keep your token safe and secure &gt; &gt; Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.  You can accept your contract using the &#x60;/my/contracts/{contractId}/accept&#x60; endpoint. You will want to navigate your command ship to a nearby asteroid field and execute the &#x60;/my/ships/{shipSymbol}/extract&#x60; endpoint to mine various types of ores and minerals.  Return to the contract destination and execute the &#x60;/my/ships/{shipSymbol}/deliver&#x60; endpoint to deposit goods into the contract.  When your contract is fulfilled, you can call &#x60;/my/contracts/{contractId}/fulfill&#x60; to retrieve payment.
        /// </summary>
        /// <exception cref="SpaceTradersUnitySDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Register201Response)</returns>
        public async System.Threading.Tasks.Task<SpaceTradersUnitySDK.Client.ApiResponse<Register201Response>> RegisterWithHttpInfoAsync(RegisterRequest registerRequest = default(RegisterRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            SpaceTradersUnitySDK.Client.RequestOptions localVarRequestOptions = new SpaceTradersUnitySDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = SpaceTradersUnitySDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SpaceTradersUnitySDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = registerRequest;

            // authentication (AgentToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var task = this.AsynchronousClient.PostAsync<Register201Response>("/register", localVarRequestOptions, this.Configuration, cancellationToken);

#if UNITY_EDITOR || !UNITY_WEBGL
            var localVarResponse = await task.ConfigureAwait(false);
#else
            var localVarResponse = await task;
#endif

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Register", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
