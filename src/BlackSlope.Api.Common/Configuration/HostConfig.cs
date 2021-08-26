namespace BlackSlope.Api.Common.Configuration
{
    public class HostConfig
    {
        public SwaggerConfig Swagger { get; set; }

        public SerilogConfig Serilog { get; set; }

        public ApplicationInsightsConfig ApplicationInsights { get; set; }
    }
}
