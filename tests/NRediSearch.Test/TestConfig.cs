using System.IO;
using System;
using Newtonsoft.Json;

namespace NRediSearch.Tests
{
    public static class TestConfig
    {
        private const string FileName = "TestConfig.json";

        public static Config Current { get; }

        static TestConfig()
        {
            Current = new Config();
            try
            {
                using (var stream = typeof(TestConfig).Assembly.GetManifestResourceStream("NRediSearch.Tests." + FileName))
                {
                    if (stream != null)
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            Current = JsonConvert.DeserializeObject<Config>(reader.ReadToEnd());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Deserializing TestConfig.json: " + ex);
            }
        }

        public class Config
        {
            public string RediSearchServer { get; set; } = "127.0.0.1";
            public int RediSearchPort { get; set; } = 6385;
            public string RediSearchServerAndPort => RediSearchServer + ":" + RediSearchPort.ToString();
        }
    }
}
