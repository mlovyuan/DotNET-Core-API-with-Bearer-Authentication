using System;
using System.IO;
using System.Globalization;
using Microsoft.Extensions.Configuration;

namespace SecureClient
{
    public class AuthConfig
    {
        public string Instance { get; set; }
        public string TenantId { get; set; }
        public string ClientId { get; set; }
        public string Authority 
        { 
            get
                {
                    // CultureInfo.InvariantCulture 不分區域文化特性處理
                    return string.Format(CultureInfo.InvariantCulture, Instance, TenantId);
                } 
        }
        public string ClientSecret { get; set; }
        public string BaseAddress { get; set; }
        public string ResourceId { get; set; }
        
        public static ReadJsonFromFile(string path)
        {
            IConfiguration configuration;
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(path);

        }

    }
}