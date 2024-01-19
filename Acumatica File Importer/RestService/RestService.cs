using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace System
{
    public class RestService : IDisposable
    {
        private HttpClient _httpClient;

        private string _acumaticaBaseUrl;
        private string _user;
        private string _pwd;
        public static bool loggedIn;
        private string _endpointName = "Default";
        private string _endpointVersion = "18.200.001";
        private string _company;
        private string _branch;
        private string _entity;
        public string errorMessage = "";

        public RestService(string acumaticaBaseUrl, string user, string pwd, string company, string branch, string entity)
        {
            _acumaticaBaseUrl = acumaticaBaseUrl;
            _user = user;
            _pwd = pwd;
            _company = company;
            _branch = branch;
            _entity = entity;

        }

        void IDisposable.Dispose()
        {
            _httpClient.PostAsync(_acumaticaBaseUrl + "/entity/auth/logout",
              new ByteArrayContent(new byte[0])).Wait();
            _httpClient.Dispose();
        }

        public void Logout()
        {
            _httpClient.PostAsync(_acumaticaBaseUrl + "/entity/auth/logout",
             new ByteArrayContent(new byte[0])).Wait();
            _httpClient.Dispose();
        }

        //Attachment of a file to a record
        public string PutFile(string key,
          string fileName, System.IO.Stream file)
        {
            HttpResponseMessage res;
            var attachFileUrl = _acumaticaBaseUrl + "/entity/" + this._endpointName + "/" + this._endpointVersion + "/" + this._entity + "/" + key + "/files/" + fileName;

            //Attach a file to a stock item record
            res = _httpClient.PutAsync(attachFileUrl, new StreamContent(file)).Result;

            errorMessage = res.Content.ReadAsStringAsync().Result;

            Logout();

            return res.Content.ReadAsStringAsync().Result;
        }

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        public string PutFileByVendorReference(string key, string vendorReferenceTxt, string referenceNbr,
         string fileName, System.IO.Stream file)
        {
            this._endpointName = "custom";
            HttpResponseMessage res;
            var attachFileUrl = _acumaticaBaseUrl + "/entity/" + this._endpointName + "/" + this._endpointVersion + "/" + this._entity + "/byVendorReference";

            var vendorReference = new VendorReferenceEntity.Root
            {
                entity = new VendorReferenceEntity.Entity
                {
                    //ReferenceNbr = new VendorReferenceEntity.ReferenceNbr
                    //{
                    //    value = referenceNbr
                    //},
                    //Type = new VendorReferenceEntity.Type
                    //{
                    //    value = key
                    //}
                },
                parameters = new VendorReferenceEntity.Parameters
                {
                    File = new VendorReferenceEntity.File { value = Convert.ToBase64String(ReadFully(file)) },
                    FileName = new VendorReferenceEntity.FileName { value = fileName },
                    Ref = new VendorReferenceEntity.Ref
                    {
                        value = vendorReferenceTxt
                    },
                    RefNbr = new VendorReferenceEntity.RefNbr { value = referenceNbr }

                }
            };

            var json = JsonConvert.SerializeObject(vendorReference, Formatting.None);
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            //Attach a file to a stock item record
            res = _httpClient.PostAsync(attachFileUrl, byteContent).Result;

            errorMessage = res.Content.ReadAsStringAsync().Result;

            Logout();

            return res.Content.ReadAsStringAsync().Result;
        }


        public string fetchInventory(string key)
        {
            HttpResponseMessage res;
            var attachFileUrl = _acumaticaBaseUrl + "/entity/" + this._endpointName + "/" + this._endpointVersion + "/" + this._entity + "/" + key;

            //Attach a file to a stock item record
            res = _httpClient.GetAsync(attachFileUrl).Result;

            Logout();

            return res.Content.ReadAsStringAsync().Result;
        }

        public HttpResponseMessage LoginAsync(string acumaticaBaseUrl, string userName, string password,
          string company, string branch)
        {
            try
            {
                var mainUrl = new Uri(_acumaticaBaseUrl);
                //_acumaticaBaseUrl = acumaticaBaseUrl;

                _httpClient = new HttpClient(
         new HttpClientHandler
         {
             UseCookies = true,
             CookieContainer = new CookieContainer()
         }, false)
                {
                    BaseAddress = mainUrl,
                    DefaultRequestHeaders =
            {
                Accept = {MediaTypeWithQualityHeaderValue.Parse("application/json")}
            }
                };
                var user = new Dictionary<string, string>
              {
                  { "name" , _user },
                  { "password" , _pwd},
                  { "company" ,_company },
                  { "branch" , _branch }
              };
                var json = JsonConvert.SerializeObject(user, Formatting.None);

                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                var result = _httpClient.PostAsync(
                   _acumaticaBaseUrl + "/entity/auth/login", stringContent);

                if (result.Result.Content.ReadAsStringAsync().Result.Contains("Invalid credentials"))
                    errorMessage = "Invalid Credentials.";
                else if (result.Result.Content.ReadAsStringAsync().Result.Contains("account is locked out"))
                    errorMessage = "Account Is locked Out.";
                else if (result.Result.Content.ReadAsStringAsync().Result.Contains("Internal Server Error"))
                    errorMessage = "Internal Server Error.";
                else if (result.Result.Content.ReadAsStringAsync().Result.Length == 0)
                    errorMessage = "Connected";
                else if (result.Result.Content.ReadAsStringAsync().Result.Contains("API Login Limit"))
                    errorMessage = "API Login Limit Reached.";
                else if (result.Result.Content.ReadAsStringAsync().Result.Contains("An error occurred while sending the request"))
                    errorMessage = "An error occurred while sending the request.";
                else
                    errorMessage = "Unable To Connect.";

                //An error occurred while sending the request.
                return result.Result;
                //.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                throw e;
            }

        }

    }
    public class RefNbr
    {
        public string value { get; set; }
    }

    public class Root
    {
        public RefNbr RefNbr { get; set; }
        public string note { get; set; }
    }

    public class FileWithNote
    {
        public string comment { get; set; }
        public byte[] file { get; set; }
        public string key { get; set; }
    }




}

namespace VendorReferenceEntity
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Type
    {
        public string value { get; set; }
    }

    public class ReferenceNbr
    {
        public string value { get; set; }
    }

    public class Entity
    {
        public Type Type { get; set; }
        public ReferenceNbr ReferenceNbr { get; set; }
    }

    public class FileName
    {
        public string value { get; set; }
    }

    public class Ref
    {
        public string value { get; set; }
    }

    public class RefNbr
    {
        public string value { get; set; }
    }

    public class File
    {
        public string value { get; set; }
    }

    public class Parameters
    {
        public FileName FileName { get; set; }
        public Ref Ref { get; set; }
        public RefNbr RefNbr { get; set; }
        public File File { get; set; }
    }

    public class Root
    {
        public Entity entity { get; set; }
        public Parameters parameters { get; set; }
    }


}