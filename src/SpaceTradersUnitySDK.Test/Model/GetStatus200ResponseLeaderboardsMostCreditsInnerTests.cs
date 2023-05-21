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
using System.Linq;
using System.IO;
using System.Collections.Generic;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Model;
using SpaceTradersUnitySDK.Client;
using System.Reflection;
using Newtonsoft.Json;
using NUnit.Framework;

namespace SpaceTradersUnitySDK.Test.Model
{
    /// <summary>
    ///  Class for testing GetStatus200ResponseLeaderboardsMostCreditsInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetStatus200ResponseLeaderboardsMostCreditsInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetStatus200ResponseLeaderboardsMostCreditsInner
        //private GetStatus200ResponseLeaderboardsMostCreditsInner instance;

        public GetStatus200ResponseLeaderboardsMostCreditsInnerTests()
        {
            // TODO uncomment below to create an instance of GetStatus200ResponseLeaderboardsMostCreditsInner
            //instance = new GetStatus200ResponseLeaderboardsMostCreditsInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetStatus200ResponseLeaderboardsMostCreditsInner
        /// </summary>
        [Test]
        public void GetStatus200ResponseLeaderboardsMostCreditsInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetStatus200ResponseLeaderboardsMostCreditsInner
            //Assert.IsType<GetStatus200ResponseLeaderboardsMostCreditsInner>(instance);
        }

        /// <summary>
        /// Test the property 'AgentSymbol'
        /// </summary>
        [Test]
        public void AgentSymbolTest()
        {
            // TODO unit test for the property 'AgentSymbol'
        }
        /// <summary>
        /// Test the property 'Credits'
        /// </summary>
        [Test]
        public void CreditsTest()
        {
            // TODO unit test for the property 'Credits'
        }
    }
}
