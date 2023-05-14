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
    ///  Class for testing JumpShip200ResponseData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class JumpShip200ResponseDataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for JumpShip200ResponseData
        //private JumpShip200ResponseData instance;

        public JumpShip200ResponseDataTests()
        {
            // TODO uncomment below to create an instance of JumpShip200ResponseData
            //instance = new JumpShip200ResponseData();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of JumpShip200ResponseData
        /// </summary>
        [Test]
        public void JumpShip200ResponseDataInstanceTest()
        {
            // TODO uncomment below to test "IsType" JumpShip200ResponseData
            //Assert.IsType<JumpShip200ResponseData>(instance);
        }

        /// <summary>
        /// Test the property 'Cooldown'
        /// </summary>
        [Test]
        public void CooldownTest()
        {
            // TODO unit test for the property 'Cooldown'
        }
        /// <summary>
        /// Test the property 'Nav'
        /// </summary>
        [Test]
        public void NavTest()
        {
            // TODO unit test for the property 'Nav'
        }
    }
}
