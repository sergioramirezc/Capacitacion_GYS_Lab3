using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.App.Models.Common
{
    public class Constants
    {
        public const string BaseEndpoint = "http://lab3.azurewebsites.net";

        public struct ErrorTypes
        {
            public const string Service = "Service";
            public const string ViewModel = "ViewModel";
        }

        public struct HttpMethod
        {
            public const string Get = "Get";
            public const string Post = "Post";
            public const string Put = "Put";
        }
    }
}
