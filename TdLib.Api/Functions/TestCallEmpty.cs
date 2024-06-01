using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Does nothing; for testing only. This is an offline method. Can be called before authorization
        /// </summary>
        public class TestCallEmpty : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "testCallEmpty";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Does nothing; for testing only. This is an offline method. Can be called before authorization
        /// </summary>
        public static Task<Ok> TestCallEmptyAsync(
            this Client client)
        {
            return client.ExecuteAsync(new TestCallEmpty
            {
                
            });
        }
    }
}
// REUSE-IgnoreEnd