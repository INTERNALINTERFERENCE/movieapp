using Config.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Shared.Services.JsonReader
{
    public class JsonConfig
    {
        public ISettings Settings = new ConfigurationBuilder<ISettings>()
            .UseJsonConfig()
            .Build();
    }
}
