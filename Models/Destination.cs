using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace TravelClient.Models
{
    public class Destination
    {
        public int DestinationId {get;set;}
        public string Name {get;set;}
        public string City {get;set;}
        public string Country {get;set;}
        public double AvgRating {get;set;}
        public ICollection<Review> Reviews { get; set; }

        //API REQUEST METHOD
        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
        //SHOWS ALL DESTINATIONS
        public static List<Destination> GetAllDestinations()
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("destinations", Method.GET);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());
            return destinationList;
        }
        //CREATES A NEW DESTINATION THROUGH API
        public static void AddDestination(Destination destination)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("destinations", Method.POST);
            request.AddJsonBody(destination);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        }
        //SHOWS DETAILS FOR A SINGLE DESTINATION
        public static Destination GetDestinationDetails(int id)
        {
            {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("destinations/"+id, Method.GET);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            var destination = JsonConvert.DeserializeObject<Destination>(jsonResponse.ToString());
            return destination;
            }
        }
        //DELETES THE DESTINATION
        public static void DeleteDestination(int id)
        {
            {
                var client = new RestClient("http://localhost:5000/api/");
                var request = new RestRequest("destinations/"+id, Method.DELETE);
                var response = new RestResponse();
                Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            }
        }


    }
}