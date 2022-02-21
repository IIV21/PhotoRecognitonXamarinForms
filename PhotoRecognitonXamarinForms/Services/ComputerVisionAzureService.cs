using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PhotoRecognition.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PhotoRecognitonXamarinForms.Services
{
    public class ComputerVisionAzureService : BaseViewModel
    {
        public static string subscriptionKey = "d2debd78a8a44cfcb5fdf851b22d0dde";
        public static string endpoint = "https://testaj.cognitiveservices.azure.com";

        public DetailsModel Items { get; set; }
        public static string returnaj { get; set; }

        public  async Task<DetailsModel> AnalyzeFromStreamAsync(string imageFilePath)
        {
            if (!File.Exists(imageFilePath))
            {
                return null;
            }

            try
            {
                HttpClient client = new HttpClient();
                
                // Request headers.
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

                // Request parameters. A third optional parameter is "details".
                // Comment parameters that aren't required
                string requestParameters = "visualFeatures=" +
                    "Categories" +
                    ",Description" +
                    ",Color" +
                    ",Tags" +
                    ",Faces" +
                    ",ImageType" +
                    ",Adult" +
                    ",Brands" +
                    ",Objects"
                    ;

                // Assemble the URI for the REST API method.
                string uri = $"{endpoint}/vision/v3.2/analyze?{requestParameters}";

                // Read the contents of the specified local image
                // into a byte array.
                byte[] byteData = GetImageAsByteArray(imageFilePath);

                // Add the byte array as an octet stream to the request body.
                using (ByteArrayContent content = new ByteArrayContent(byteData))
                {
                    // This example uses the "application/octet-stream" content type.
                    // The other content types you can use are "application/json" and "multipart/form-data".
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                    // Asynchronously call the REST API method.
                    HttpResponseMessage response = await client.PostAsync(uri, content);
                    // Asynchronously get the JSON response.
                    string contentString = await response.Content.ReadAsStringAsync();

                    // Display the JSON response.
                    returnaj = JToken.Parse(contentString).ToString();
                    Items = JsonConvert.DeserializeObject<DetailsModel>(contentString);
                    return Items;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message);
                return null;
            }
        }

        byte[] GetImageAsByteArray(string imageFilePath)
        {
            // Open a read-only file stream for the specified file.
            using (FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                // Read the file's contents into a byte array.
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }
    }
}

