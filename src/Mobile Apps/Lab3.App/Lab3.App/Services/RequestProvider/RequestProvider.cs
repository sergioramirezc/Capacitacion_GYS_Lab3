using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System;
using Lab3.App.Services;
using Microsoft.AppCenter.Crashes;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace Lab3.App.Services.RequestProvider
{
    public class RequestProvider : IRequestProvider
    {
        private readonly JsonSerializerSettings _serializerSettings;
        private static HttpClient instance;

        public RequestProvider()
        {
            _serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore
            };
            _serializerSettings.Converters.Add(new StringEnumConverter());
        }

        public async Task<TResult> GetAsync<TResult>(string uri, string token = "")
        {
            try
            {
                HttpClient httpClient = await CreateHttpClient(uri);
                HttpResponseMessage response = await httpClient.GetAsync(uri);

                await HandleResponse(response);
                string serialized = await response.Content.ReadAsStringAsync();

                TResult result = await Task.Run(() =>
                    JsonConvert.DeserializeObject<TResult>(serialized, _serializerSettings));

                return result;
            }
            catch (Exception ex)
            {
                var properties = new Dictionary<string, string> {
                    { "Type", Models.Common.Constants.ErrorTypes.Service },
                    { "Url", uri },
                    { "Method", Models.Common.Constants.HttpMethod.Get }
                };
                Crashes.TrackError(ex, properties);
                throw ex;
            }
        }

        public async Task<TResult> PostAsync<TResult>(string uri, TResult data, string token = "", string header = "")
        {
            try
            {
                HttpClient httpClient = await CreateHttpClient(uri);

                if (!string.IsNullOrEmpty(header))
                {
                    AddHeaderParameter(httpClient, header);
                }

                var content = new StringContent(JsonConvert.SerializeObject(data));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uri, content);
                await HandleResponse(response);
                string serialized = await response.Content.ReadAsStringAsync();

                TResult result = await Task.Run(() =>
                    JsonConvert.DeserializeObject<TResult>(serialized, _serializerSettings));

                return result;
            }
            catch (Exception ex)
            {
                var properties = new Dictionary<string, string> {
                    { "Type", Models.Common.Constants.ErrorTypes.Service },
                    { "Url", uri },
                    { "Method", Models.Common.Constants.HttpMethod.Post }
                };
                Crashes.TrackError(ex, properties);
                return default(TResult);
            }
        }

        public async Task<TOutput> PostAsync<TOutput, TInput>(string uri, TInput data, string token = "", string header = "")
        {
            try
            {
                HttpClient httpClient = await CreateHttpClient(uri);

                if (!string.IsNullOrEmpty(header))
                {
                    AddHeaderParameter(httpClient, header);
                }

                var content = new StringContent(JsonConvert.SerializeObject(data));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uri, content);
                await HandleResponse(response);
                string serialized = await response.Content.ReadAsStringAsync();

                TOutput result = await Task.Run(() =>
                    JsonConvert.DeserializeObject<TOutput>(serialized, _serializerSettings));

                return result;
            }
            catch (Exception ex)
            {
                var properties = new Dictionary<string, string> {
                    { "Type", Models.Common.Constants.ErrorTypes.Service },
                    { "Url", uri },
                    { "Method", Models.Common.Constants.HttpMethod.Post }
                };
                Crashes.TrackError(ex, properties);
                return default(TOutput);
            }
        }

        public async Task<TOutput> PutAsync<TOutput, TResult>(string uri, TResult data, string token = "", string header = "")
        {
            try
            {
                HttpClient httpClient = await CreateHttpClient(uri);

                if (!string.IsNullOrEmpty(header))
                {
                    AddHeaderParameter(httpClient, header);
                }

                var content = new StringContent(JsonConvert.SerializeObject(data));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PutAsync(uri, content);

                await HandleResponse(response);
                string serialized = await response.Content.ReadAsStringAsync();

                TOutput result = await Task.Run(() =>
                    JsonConvert.DeserializeObject<TOutput>(serialized, _serializerSettings));

                return result;
            }
            catch (Exception ex)
            {
                var properties = new Dictionary<string, string> {
                    { "Type", Models.Common.Constants.ErrorTypes.Service },
                    { "Url", uri },
                    { "Method", "Put" }
                };
                Crashes.TrackError(ex, properties);

                throw;
            }
        }

        public async Task DeleteAsync(string uri, string token = "")
        {
            HttpClient httpClient = await CreateHttpClient(uri);
            await httpClient.DeleteAsync(uri);
        }

        private async Task<HttpClient> CreateHttpClient(string uri = "")
        {
            var httpClient = GetInstance();
            return httpClient;
        }

        private static HttpClient GetInstance()
        {
            if (instance == null)
            {
                instance = new HttpClient();
                instance.Timeout = TimeSpan.FromSeconds(30);
                instance.MaxResponseContentBufferSize = 256000;
                instance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

            return instance;
        }

        private void AddHeaderParameter(HttpClient httpClient, string parameter)
        {
            if (httpClient == null)
                return;

            if (string.IsNullOrEmpty(parameter))
                return;

            httpClient.DefaultRequestHeaders.Add(parameter, Guid.NewGuid().ToString());
        }

        private async Task HandleResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                throw new HttpRequestException(content);
            }
        }
    }
}