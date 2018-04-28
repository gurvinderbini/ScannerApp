using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ScannerApp.Backend.Apis;

namespace ScannerApp.Backend.HttpClinetHelper
{
    public class HttpClientHelper
    {
        #region Constants & Statics
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings();
        private const int MaxRetryCount = 5;
        #endregion 

        #region Properties

        protected string BaseUrl { get; set; } = ApiBase.BaseUrl;
        #endregion

        #region GetServicePathUri

        protected Uri GetServicePathUri(string path)
        {
            return new Uri(new Uri(BaseUrl), path);
        }

        #endregion

        #region Http Requests

        #region Get

        public async Task<T> HttpGetRequest<T>(String requestPath)
        {
            return await HttpGetRequest<T>(requestPath, null);
        }

        public async Task<T> HttpGetRequest<T>(String requestPath, AuthenticationHeaderValue header)
        {
            string jsonString = string.Empty;

            try
            {
                var data = await HttpGetRequestInternal(requestPath);
                for (int i = 0; i < MaxRetryCount && data.Item1 == false; i++)
                {
                    data = await HttpGetRequestInternal(requestPath);
                }
                jsonString = data.Item2;

                return JsonConvert.DeserializeObject<T>(jsonString, Settings);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in deserialization of: [{jsonString}]: {ex.Message}", ex);
            }
        }

        #region Get Root Call

        protected async Task<Tuple<bool, string>> HttpGetRequestInternal(String requestPath)
        {
            using (var client = new HttpClient())
            {
                //if (!string.IsNullOrEmpty(Utils.CurrentUser.Token))
                //{
                //    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Utils.CurrentUser.Token);

                //}
                HttpResponseMessage response = await client.GetAsync(GetServicePathUri(requestPath));
                string jsonString = string.Empty;
                try
                {
                    jsonString = await response.Content.ReadAsStringAsync();
                    return new Tuple<bool, string>(true, jsonString);

                }
                catch (Exception ex)
                {
                    jsonString = ex.Message;
                }
                return new Tuple<bool, string>(false, jsonString);
            }
        }

        #endregion

        #endregion

        #region Post

        public async Task<T> HttpPostRequest<T>(string requestPath, Dictionary<string, string> form)
        {
            return await HttpPostRequest<T>(requestPath, null, form);
        }

        public async Task<T> HttpPostRequest<T>(string requestPath, AuthenticationHeaderValue header, Dictionary<string, string> form)
        {
            string jsonString = string.Empty;

            try
            {
                var data = await HttpPostRequestInternal(requestPath, header, form);
                for (int i = 0; i < MaxRetryCount && data.Item1 == false; i++)
                {
                    data = await HttpGetRequestInternal(requestPath);
                }
                jsonString = data.Item2;
                var result = JsonConvert.DeserializeObject<T>(jsonString, Settings);

                return result;
            }
            catch (Exception e)
            {
                throw new Exception($"Error in deserialization of: [{jsonString}]: {e.Message}", e);
            }
        }


        #region POST Root Call

        protected async Task<Tuple<bool, string>> HttpPostRequestInternal(String requestPath,
            AuthenticationHeaderValue header, Dictionary<string, string> form)
        {
            using (var client = new HttpClient())
            {
                //if (!string.IsNullOrEmpty(Utils.CurrentUser.Token))
                //{
                //    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Utils.CurrentUser.Token);
                //}
                HttpResponseMessage response = await client.PostAsync(GetServicePathUri(requestPath), new FormUrlEncodedContent(form));
                string jsonString = String.Empty;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    try
                    {
                        jsonString = await response.Content.ReadAsStringAsync();
                        return new Tuple<bool, string>(true, jsonString);
                    }
                    catch (Exception ex)
                    {
                        jsonString = ex.Message;
                    }
                }
                return new Tuple<bool, string>(false, jsonString);
            }
        }

        #endregion

        #endregion

        #endregion

        #region API Request Headers 

        public AuthenticationHeaderValue LoginApiHeader()
        {
            return null;
        }

        public AuthenticationHeaderValue PostLoginApiHeader()
        {
            return null;
        }
        #endregion

    }
}
