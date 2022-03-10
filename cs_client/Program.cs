using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace cs_client
{
    class Post
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }

    class Program
    {
        static void Main()
        {
            HttpClient client = new HttpClient();

            // var message = new HttpRequestMessage
            // {
            //     Method = HttpMethod.Get,
            //     RequestUri = new Uri("https://www.google.com/")
            //     // RequestUri = new Uri("https://jsonplaceholder.typicode.com/posts")
            //     // RequestUri = new Uri("https://jsonplaceholder.typicode.com/posts/1")
            // };
            // 
            // HttpResponseMessage response = client.SendAsync(message).Result;
            // GetAsync(), PostAsync(), PutAsync(), DeleteAsync()


            // Console.WriteLine(response); 
            // Console.WriteLine(response.StatusCode); 

            // var html = response.Content.ReadAsStringAsync().Result;
            // Console.WriteLine(html);



            // var json = response.Content.ReadAsStringAsync().Result;

            // var post = JsonSerializer.Deserialize<Post>(json);
            // Console.WriteLine(post.title);


            // var posts = JsonSerializer.Deserialize<List<Post>>(json);
            // 
            // foreach (var post in posts)
            // {
            //     Console.WriteLine(post.UserId);
            //     Console.WriteLine(post.Id);
            //     Console.WriteLine(post.title);
            //     Console.WriteLine(post.body);
            // 
            //     Console.WriteLine();
            // }


            // Console.WriteLine(json);



            HttpResponseMessage response = client.GetAsync("http://localhost:45789/").Result;
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);

        }
    }


    

}










// // WebClient
// // FTP & HTTP
// 
// var webClient = new WebClient();
// Console.WriteLine(webClient.DownloadString("https://www.google.com/"));


//  HttpWebRequest, HttpWebResponse
