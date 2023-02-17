using System.ComponentModel.DataAnnotations;

namespace ValidateSettings
{
    public class TestOptions
    {
        public const string SectionName = "Test";

        public string LogLevel { get; init; }
        
        [Range(1, 9)]
        public int Retries { get; init; }
    }
}
