using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Returns the received vector of objects containing a string; for testing only. This is an offline method. Can be called before authorization
        /// </summary>
        public class TestCallVectorStringObject : Function<TestVectorStringObject>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "testCallVectorStringObject";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Vector of objects to return
            /// </summary>
            [JsonProperty("x", ItemConverterType = typeof(Converter))]
            public TestString[] X { get; set; }
        }

        /// <summary>
        /// Returns the received vector of objects containing a string; for testing only. This is an offline method. Can be called before authorization
        /// </summary>
        public static Task<TestVectorStringObject> TestCallVectorStringObjectAsync(
            this Client client, TestString[] x = default)
        {
            return client.ExecuteAsync(new TestCallVectorStringObject
            {
                X = x
            });
        }
    }
}