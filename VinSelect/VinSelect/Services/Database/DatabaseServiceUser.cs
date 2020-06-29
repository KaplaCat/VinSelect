using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VinSelect.Services.Database
{
    public partial class DatabaseService : IDatabaseService
    {
        public void DeleteUser(string id)
        {
            var client = new RestClient("https://account-b600.restdb.io/rest/users/"+id);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "94215d810a67857c7e21c1be383a09a6ee99f");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
        }

        public IRestResponse GetAllUsers()
        {
            var client = new RestClient("https://account-b600.restdb.io/rest/users");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "94215d810a67857c7e21c1be383a09a6ee99f");
            request.AddHeader("content-type", "application/json");
            return client.Execute(request);
        }

        public void PostNewUser(string json)
        {
            var client = new RestClient("https://account-b600.restdb.io/rest/users");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "94215d810a67857c7e21c1be383a09a6ee99f");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

        public void UpdateUser(string id, string field)
        {
            var client = new RestClient("https://account-b600.restdb.io/rest/users/"+id);
            var request = new RestRequest(Method.PUT);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "94215d810a67857c7e21c1be383a09a6ee99f");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", field, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }
    }
}
