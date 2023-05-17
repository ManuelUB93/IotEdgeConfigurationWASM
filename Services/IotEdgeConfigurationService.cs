using IotEdgeConfigurationWASM.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace IotEdgeConfigurationWASM.Services
{

    public class IotEdgeConfigurationService
    {
        HttpClient _client = new()
        {
            BaseAddress = new Uri("http://localhost:7185/api/")
        };

        public async Task<Nodes> GetConfiguredNodes(IotHubPayload s)
        {
            var url = "GetConfiguredNodes";
            try
            {
                var response = await _client.PostAsJsonAsync(url, s);
                var responseMessage = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<Nodes>(responseMessage)!;
                return responseObj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return new();
        }
        public async Task RemoveNode(IotHubPayload s)
        {
            var url = "RemoveNode";
            try
            {
                var response = await _client.PostAsJsonAsync(url, s);
                var responseMessage = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject(responseMessage)!;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public async Task AddNode(IotHubPayload s)
        {
            var url = "AddNode";
            try
            {
                var response = await _client.PostAsJsonAsync(url, s);
                var responseMessage = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject(responseMessage)!;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public async Task<HashSet<NodeTreeView>> Browse(string s)
        {
            var url = "Browse";
            HashSet<NodeTreeView> nodes = new HashSet<NodeTreeView>();
            try
            {
                var response = await _client.PostAsJsonAsync(url, new { url = s });
                var responseMessage = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<HashSet<NodeTreeView>>(responseMessage)!;
                foreach (var item in responseObj)
                {
                    nodes.Add(item);
                }
                return nodes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return nodes;
        }
        public async Task<string> CreateIoTDevice(string deviceId)
        {
            var url = "CreateIotDevice";

            // Create an anonymous object with the device ID parameter
            var jsonPayload = new { deviceId = deviceId };
            // Call the function and get the response
            HttpResponseMessage httpResponseMessage = await _client.PostAsJsonAsync(url, jsonPayload);
            string responseContent = await httpResponseMessage.Content.ReadAsStringAsync();
            // Return the response body
            return responseContent;

        }
        public async Task<List<IotHubDevice>> GetDevices()
        {
            var url = "GetDevices";       
          
            // Call the function and get the response
            HttpResponseMessage httpResponseMessage = await _client.GetAsync(url);
            string responseContent = await httpResponseMessage.Content.ReadAsStringAsync();
            var devices = JsonConvert.DeserializeObject<List<IotHubDevice>>(responseContent)!;
            // Return the response body
            return devices;

        }
        public async Task<HashSet<NodeTreeView>> Browse(string s, NodeTreeView parentNode)
        {
            var url = "Browse";
            HashSet<NodeTreeView> nodes = new HashSet<NodeTreeView>();
            try
            {
                var response = await _client.PostAsJsonAsync(url, new { url = s, parentnode = parentNode.NodeId });
                var responseMessage = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<HashSet<NodeTreeView>>(responseMessage)!;
                foreach (NodeTreeView item in responseObj)
                {
                    nodes.Add(item);
                }
                return nodes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return nodes;
        }
    }
}
