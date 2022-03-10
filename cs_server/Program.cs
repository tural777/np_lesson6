using System;
using System.IO;
using System.Net;

namespace cs_server
{
    class Program
    {
        static void Main()
        {
            var listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:45789/");
            listener.Prefixes.Add("http://localhost:45678/");

            listener.Start(); // Listen, Start


            while (true)
            {
                var context = listener.GetContext(); // Accept + Receive

                var request = context.Request;
                var response = context.Response;



                //for (int i = 0; i < request.QueryString.Count; i++)
                //{
                //    Console.WriteLine(request.QueryString[i]);

                //}


                // foreach (string key in request.QueryString.Keys)
                // {
                //     // Console.WriteLine(request.QueryString.Get(key));
                //     Console.WriteLine(request.QueryString[key]);
                // }



                // // Media types (mime types)
                // response.AddHeader("Content-Type", "text/html");
                // response.AddHeader("Content-Type", "text/plain");



                StreamWriter sw = new StreamWriter(response.OutputStream);
                sw.WriteLine("<h1 style='color:red;'> Salam Dunya <h1>");
                // sw.Flush();
                sw.Close();


           


                // response.StatusCode = 404;
                // response.Close();

            }
        }
    }
}
