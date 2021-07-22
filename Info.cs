using Microsoft.OpenApi.Models;

namespace ConfigSwagger
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}