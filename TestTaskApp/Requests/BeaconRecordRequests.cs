using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTaskApp.Requests
{
    public static class BeaconRecordRequests
    {
        private const string _url = "https://beacon.nist.gov/rest/record/{0}";

        /// <summary>
        /// Get Data from Beacon
        /// </summary>
        /// <param name="_dateEpoch">Datetime in Epoch format</param>
        /// <returns>Output Value from Beacon XML</returns>
        public static async Task<string> GetOutputValue(Int32 _dateEpoch)
        {
            var outputValue = string.Empty;

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();

                    using (var response = await client.GetAsync(string.Format(_url, _dateEpoch)))
                    {
                        var _content = await response.Content.ReadAsStringAsync();
                        if (response?.IsSuccessStatusCode == true)
                        {
                            // Getting OutputValue from response XML
                            var match = Regex.Match(_content, "<outputValue>(.*?)</outputValue>");
                            if (match.Success)
                            {
                                outputValue = match.Groups[1].Value;
                            }
                        }
                        else
                        if (response.StatusCode == System.Net.HttpStatusCode.RequestTimeout)
                        {
                            Helpers.ErrorLog.Log("Request Timeout");
                        }
                        else
                        if (!string.IsNullOrWhiteSpace(_content))
                        {
                            // Error message from server
                            Helpers.ErrorLog.Log(_content);
                        }
                        else
                        {
                            Helpers.ErrorLog.Log("Request Status is FALSE");
                        }
                    }
                }
            }
            catch (HttpRequestException hrex)
            {
                // I can extract extend exception specific information, but not in this time
                Helpers.ErrorLog.Log(hrex);
            }
            catch (TaskCanceledException tcex)
            {
                // I can extract extend exception specific information, but not in this time
                Helpers.ErrorLog.Log(tcex);
            }
            catch (Exception ex)
            {
                Helpers.ErrorLog.Log(ex);
            }

            return outputValue;
        }
    }
}
