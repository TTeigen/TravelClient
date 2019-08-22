using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;




namespace TravelClient.Models
{
    [Table("reviews")]
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int DestinationId { get; set; }
        [Required]
        public string ReviewText { get; set; }
        [Required]
        public string Author { get; set; }
        [Range(0,10)]
        public int Rating { get; set; }


  public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
      public static void AddReview(Review review)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("reviews", Method.POST);
            request.AddJsonBody(review);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        }
          public static void DeleteReview(int id)
        {
            {
                var client = new RestClient("http://localhost:5000/api/");
                var request = new RestRequest("reviews/"+id, Method.DELETE);
                var response = new RestResponse();
                Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            }
        }


    }
}