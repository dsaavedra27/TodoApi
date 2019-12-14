using System;
using System.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.VisualBasic;
using System.IO; 
using TodoApi;
using System.Linq;
using TodoApi.Models;
using System.Collections.Generic;



namespace TodoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            // (@"C:\Users\e140621\Desktop\TodoApi\TodoApiv\Top.csv"


    }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                 .UseStartup<Startup>();

       
        }




    } 
 
   
 

